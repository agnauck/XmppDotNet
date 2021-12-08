using System.IO;
using System.Reflection;

namespace XmppDotNet.Tests
{
    public static class Resource
    {
        public static string Get(string path)
        {
            Assembly assembly = typeof(Resource).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"XmppDotNet.Tests.{path}");
            using (StreamReader reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }
    }
}
