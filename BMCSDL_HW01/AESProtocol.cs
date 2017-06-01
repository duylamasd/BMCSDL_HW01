using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_HW01
{
    public class AESProtocol
    {
        private AesCryptoServiceProvider cryptoService { get; set; }
        public byte[] IV { get; set; }

        public AESProtocol()
        {
            cryptoService = new AesCryptoServiceProvider();
            cryptoService.GenerateIV();
            IV = cryptoService.IV;
            cryptoService.Mode = CipherMode.CBC;
            cryptoService.Padding = PaddingMode.ANSIX923;
        }

        public byte[] encryptBytes(byte[] plain, byte[] key)
        {
            byte[] encryptedBytes;

            cryptoService.Key = key;
            ICryptoTransform encryptor = cryptoService.CreateEncryptor(cryptoService.Key,
                                                                        cryptoService.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor,
                                                                CryptoStreamMode.Write))
                {
                    csEncrypt.Write(plain, 0, plain.Length);
                }

                encryptedBytes = msEncrypt.ToArray();
            }

            byte[] finalArray = encryptedBytes;

            return finalArray;
        }

        public byte[] decryptBytes(byte[] sourceBytes, byte[] key, byte[] IV)
        {
            byte[] decryptedBytes;

            cryptoService.IV = IV;
            cryptoService.Key = key;

            ICryptoTransform decryptor = cryptoService.CreateDecryptor(key, IV);

            using (MemoryStream msDecrypt = new MemoryStream())
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor,
                                                                CryptoStreamMode.Write))
                {
                    csDecrypt.Write(sourceBytes, 0, sourceBytes.Length);
                }

                decryptedBytes = msDecrypt.ToArray();
            }

            return decryptedBytes;
        }
    }
}
