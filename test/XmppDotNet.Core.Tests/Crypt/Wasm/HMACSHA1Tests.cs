using System.Text;
using Shouldly;
using XmppDotNet.Crypt.Wasm;
using Xunit;

namespace XmppDotNet.Tests.Crypt.Wasm;

public class HMACSHA1Tests
{
    [Fact]
    public void HMACSHA1Test()
    {
        string message = "what do ya want for nothing?";
        string secretKey = "Jefe";
        string expectedHMAC = "effcdf6ae5eb2fa2d27416d5f184df9c259a7c79";
       
        var h =new HMACSHA1(Encoding.ASCII.GetBytes(secretKey));
        var res = h.ComputeHash(Encoding.ASCII.GetBytes(message));
        
        res.ToHex().ShouldBe(expectedHMAC);
    }
}