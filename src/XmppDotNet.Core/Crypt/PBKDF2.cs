namespace XmppDotNet.Crypt
{
    using System;
    using System.Security.Cryptography;

    public static class PBKDF2
    {
        public static byte[] Derive(string pass, byte[] salt, int iterations)
        {
            try
            {
// Disable the warning.
#pragma warning disable SYSLIB0041
                var pdb = new Rfc2898DeriveBytes(pass, salt, iterations);
// Re-enable the warning.
#pragma warning restore SYSLIB0041
                return pdb.GetBytes(20);
            }
            catch (PlatformNotSupportedException)
            {
                var pdb = new Wasm.Rfc2898DeriveBytes(pass, salt, iterations);
                return pdb.GetBytes(20);
            }
        }
    }
}
