using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoLib
{
    public interface ICryptoFacade
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
