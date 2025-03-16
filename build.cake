#addin nuget:?package=Cake.FileHelpers&version=7.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

/*
    Additional arguments:
    ci-build:       when present a ci version should be build. Its appending
                    ci-$juliandate-$buildnumber
    rc-build:       when present a rc version should be build
                    rc.1-$juliandate-$buildnumber

    publish-nuget:  when present will push nuget packages
 */

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(context =>
{
   BuildContext.Initialize(Context);
   BuildContext.PrintParameters(Context);
});

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
    {      
        // clear all bin directories
        var binDirs = GetDirectories("./**/bin");
        foreach(var dir in binDirs)
        {
            CleanDirectory(Directory(dir.FullPath));
        }

        // clear all test results
        var testDirs = GetDirectories("./**/TestResults");
        foreach(var dir in testDirs)
        {
            CleanDirectory(Directory(dir.FullPath));
        }		
    });

Task("Update-Assembly-Version")    
    .WithCriteria(() => (BuildContext.IsCiBuild || BuildContext.IsRcBuild) && BuildContext.IsRunningOnGithub)
    .IsDependentOn("Clean")
    .Does(() =>
    {
        var year = System.DateTime.Now.ToString("yy");
        var julianYear = year.Substring(0);
        var dayOfYear = DateTime.Now.DayOfYear;
        var julianDate = julianYear + String.Format("{0:D3}", dayOfYear);      
       
        var buildIncrementalNumber = BuildContext.BuildId;
        var prefix = "ci";
        //if (HasArgument("rcversion"))
        //{
        //    prefix = "rc." + Argument<string>("rcversion");
        //}        

        var files = GetFiles("./**/version.props");
        foreach(var file in files)
        {
            var currentVersion = XmlPeek(file.FullPath, "/Project/PropertyGroup/AssemblyVersion");
            var newVersion = $"{currentVersion}-{prefix}-{julianDate}-{buildIncrementalNumber}";

            XmlPoke(file.FullPath, "/Project/PropertyGroup/FileVersion", currentVersion);
            XmlPoke(file.FullPath, "/Project/PropertyGroup/Version", newVersion);
        }        
    });

Task("Restore-NuGet-Packages")
    .IsDependentOn("Update-Assembly-Version")
    .Does(() =>
    {        
        DotNetRestore("./XmppDotNet.sln", new DotNetRestoreSettings
        {
            Verbosity = DotNetVerbosity.Minimal,
            Sources = new [] { "https://api.nuget.org/v3/index.json" }
        });
    });

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
    {        
        var path = MakeAbsolute(new DirectoryPath("./XmppDotNet.sln"));
        DotNetBuild(path.FullPath, new DotNetBuildSettings
        {
            Configuration = configuration,
            NoRestore = true,
            //MSBuildSettings = parameters.MSBuildSettings
        });
    });

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(() =>
    {
        var projects = GetFiles("./test/**/*.csproj");
        foreach(var project in projects)
        {
            DotNetTest(
                project.FullPath,
                new DotNetTestSettings()
                {
                    Configuration = configuration,
                    NoBuild = true,
                    // Outputing test results as XML so that VSTS can pick then up in another task
                    ArgumentCustomization = args => args.Append("--logger \"trx;LogFileName=TestResults.xml\"")
                });
        }
    });


Task("Publish-Nuget")
    .IsDependentOn("Run-Unit-Tests")
    .WithCriteria(() => BuildContext.ShouldPublishToNuget)
    .ContinueOnError()
    .Does(() =>
    {
        Information("start publish nuget packages");
        // Get the paths to the packages.
        var packages = GetFiles("./src/**/XmppDotNet*.nupkg");
        foreach(var package in packages)
        {
            Information("push: " + package);
            try
            {
                // Push the package.
                DotNetNuGetPush(package, new DotNetNuGetPushSettings {
                    Source = BuildContext.NugetApiUrl,
                    ApiKey = BuildContext.NugetApiKey,
                    SkipDuplicate = true
                });
            }
            catch(System.Exception ex)
            {
                // ignore
                Information(ex);
            }
        }
        Information("end push nuget packages");
    }); 
   

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Publish-Nuget");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

public static class BuildContext
{    
    public static string NugetApiUrl { get; private set; }
    public static string NugetApiKey { get; private set; }
    public static bool IsCiBuild { get; private set; }
    public static bool IsRcBuild { get; private set; }
    public static bool ShouldPublishToNuget { get; private set; }
    public static string BuildId { get; private set; }
    public static bool IsRunningOnGithub { get; private set; }
        
    public static void Initialize(ICakeContext context)
    {
        NugetApiUrl = context.EnvironmentVariable("NUGET_API_URL");
        NugetApiKey = context.EnvironmentVariable("NUGET_API_KEY");
        ShouldPublishToNuget = context.Argument<bool>("publish-nuget", false);
        IsCiBuild = context.Argument<bool>("ci-build", false);
        IsRcBuild = context.Argument<bool>("rc-build", false);
        
        if (context.BuildSystem().GitHubActions.IsRunningOnGitHubActions)
        {            
            var workflow = context.BuildSystem().GitHubActions.Environment.Workflow;
            BuildId = workflow.RunNumber.ToString();
            IsRunningOnGithub = true;
        }
    }

    public static void PrintParameters(ICakeContext context)
    {
        context.Information("Printing Build Parameters...");        
        context.Information("NugetApiUrl: {0}", NugetApiUrl);
        context.Information("NugetApiKey: {0}", NugetApiKey);
        context.Information("ShouldPublishToNuget: {0}", ShouldPublishToNuget);
        
        var workflow = context.BuildSystem().GitHubActions.Environment.Workflow;
        context.Information($"JobId: {workflow.RunId}");
        context.Information($"RunNumber: {workflow.RunNumber}");
        context.Information($"CommitId: {workflow.Sha}");
        context.Information($"CommitBranch: {workflow.Ref}");        
    }
}