using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using NETCore.Encrypt;
using NETCore.Encrypt.Internal;

namespace Comp_Security
{
    public class aes
    {


        public dynamic aesKey = EncryptProvider.CreateAesKey();
        public dynamic key => aesKey.Key;
        public dynamic iv => aesKey.IV;
    }

    public class rsa
    {
        public dynamic rsaKey = EncryptProvider.CreateRsaKey();
        public dynamic publicKey => rsaKey.PublicKey;
        public dynamic privateKey => rsaKey.PrivateKey;
    }
} 
