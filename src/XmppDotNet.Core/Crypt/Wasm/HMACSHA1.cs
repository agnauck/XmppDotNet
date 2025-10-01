namespace XmppDotNet.Crypt.Wasm
{
    using System.Security.Cryptography;

    public class HMACSHA1 : HMAC
    {
        public HMACSHA1(byte[] key)
        {
            m_hashAlgorithm = SHA1.Create();

            m_hash1 = SHA1.Create();
            m_hash2 = SHA1.Create();
          
            HashSizeValue = 160;
            InitializeKey(key);
        }
    }
}
