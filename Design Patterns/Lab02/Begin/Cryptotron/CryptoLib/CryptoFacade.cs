using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CryptoLib
{
    public class CryptoFacade : ICryptoFacade
    {
        private byte[] initVector;
        private byte[] key;
        private AesManaged provider;

        public CryptoFacade()
        {
            provider = new AesManaged();
            initVector = new byte[provider.BlockSize / 8];
            key = new byte[provider.KeySize / 8];
            using (var rngProvider = new RNGCryptoServiceProvider())
            {
                rngProvider.GetBytes(initVector);
                rngProvider.GetBytes(key);
            }
        }

        public string Encrypt(string plainText)
        {
            ICryptoTransform transform = provider.CreateEncryptor(key, initVector);
            byte[] clearBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes;
            using (var buf = new MemoryStream())
            {
                using (var stream = new CryptoStream(buf, transform, CryptoStreamMode.Write))
                {
                    stream.Write(clearBytes, 0, clearBytes.Length);
                    stream.FlushFinalBlock();
                    cipherBytes = buf.ToArray();
                }
            }
            return Convert.ToBase64String(cipherBytes);
        }

        public string Decrypt(string cipherText)
        {
            ICryptoTransform transform = provider.CreateDecryptor(key, initVector);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] clearBytes;
            using (var buf = new MemoryStream())
            {
                using (var stream = new CryptoStream(buf, transform, CryptoStreamMode.Write))
                {
                    stream.Write(cipherBytes, 0, cipherBytes.Length);
                    stream.FlushFinalBlock();
                    clearBytes = buf.ToArray();
                }
            }
            return Encoding.UTF8.GetString(clearBytes);
        }
    }
}
