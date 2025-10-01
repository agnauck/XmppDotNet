using Shouldly;
using XmppDotNet.Crypt;
using Xunit;
using System.Text;

namespace XmppDotNet.Tests.Crypt;

public class PBKDF2Tests
{
    [Fact]
    public void PBKDF2Test()
    {
        /*
        Test vector from https://www.rfc-editor.org/rfc/rfc6070#page-2
        Input:
           P = "password" (8 octets)
           S = "salt" (4 octets)
           c = 1
           dkLen = 20

        Output:
           DK = 0c 60 c8 0f 96 1f 0e 71
                f3 a9 b5 24 af 60 12 06
                2f e0 37 a6             (20 octets)
        */

        var res = PBKDF2.Derive("password", Encoding.ASCII.GetBytes("salt"), 1);
        res.ToHex().ShouldBe("0c60c80f961f0e71f3a9b524af6012062fe037a6");
    }
}
