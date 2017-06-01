using Mono.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_HW01
{
    public class RSAProtocol
    {
        private BigInteger p { get; set; }
        private BigInteger q { get; set; }
        private BigInteger n { get; set; }


        public RSAProtocol()
        {
            cryptoService = new RSACryptoServiceProvider();
        }

        public byte[] encryptBytes(byte[] plain)
        {
            byte[] cipherBytes;

            cipherBytes = cryptoService.Encrypt(plain, true);
            publicKey = cryptoService.ToXmlString(false);
            keyInfo = cryptoService.ExportParameters(true);

            return cipherBytes;
        }

        public byte[] decryptBytes(byte[] cipherBytes, RSAParameters keyInfo)
        {
            byte[] decryptedBytes;

            cryptoService.ImportParameters(keyInfo);
            decryptedBytes = cryptoService.Decrypt(cipherBytes, true);

            return decryptedBytes;
        }
    }
}
