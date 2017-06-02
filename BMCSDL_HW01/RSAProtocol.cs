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
        public BigInteger n { get; set; }
        private BigInteger lambda { get; set; }
        public BigInteger e { get; set; }
        private BigInteger d { get; set; }

        public RSAProtocol()
        {
            p = BigInteger.GeneratePseudoPrime(256);
            q = BigInteger.GeneratePseudoPrime(256);
            n = p * q;

            lambda = ((p - 1) * (q - 1)) / (p - 1).GCD(q - 1);
            e = BigInteger.GenerateRandom(256);
            while (e.GCD(lambda) != 1)
                e = BigInteger.GenerateRandom(256);
            d = e.ModInverse(lambda);
        }

        public RSAProtocol(byte[] publicKey, byte[] privateKey, byte[] mod)
        {
            e = new BigInteger(publicKey);
            d = new BigInteger(privateKey);
            n = new BigInteger(mod);
        }

        public byte[] encryptBytes(byte[] plain)
        {
            int numBlock = (plain.Length + 31) / 32;
            List<byte> encryptedArray = new List<byte>();
            List<byte[]> blockBytes = new List<byte[]>();

            #region Padding
            for (int i = 0; i < numBlock; i++)
            {
                byte[] block = new byte[32];
                if (i != numBlock - 1)
                {
                    for (int j = 0; j < 32; j++)
                        block[j] = plain[i * 32 + j];
                }
                else
                {
                    if (plain.Length % 32 == 0)
                        for (int j = 0; j < 32; j++)
                            block[j] = plain[i * 32 + j];
                    else
                    {
                        int j = 0;
                        for (j = i * 32; j < plain.Length; j++)
                            block[j - i * 32] = plain[j];
                        for (int k = j - i * 32; k < 32; k++)
                            block[k] = 0x00;
                    }
                }

                blockBytes.Add(block);
            }
            #endregion

            for (int i = 0; i < numBlock; i++)
            {
                BigInteger blockValue = new BigInteger(blockBytes[i]);
                BigInteger cipherBlock = blockValue.ModPow(e, n);
                byte[] cipherBlockBytes = cipherBlock.GetBytes();

                for (int j = 0; j < cipherBlockBytes.Length; j++)
                    encryptedArray.Add(cipherBlockBytes[j]);
            }

            return encryptedArray.ToArray();
        }

        public byte[] decryptBytes(byte[] cipherBytes)
        {
            List<byte> decryptedBytes = new List<byte>();
            int numBlocks = cipherBytes.Length / 64;
            
            for (int i = 0; i < numBlocks; i++)
            {
                byte[] blockBytes = new byte[64];
                Buffer.BlockCopy(cipherBytes, i * 64, blockBytes, 0, 64);
                BigInteger blockValue = new BigInteger(blockBytes);

                BigInteger decryptedBlockValue = blockValue.ModPow(d, n);
                byte[] decryptedBlockBytes = decryptedBlockValue.GetBytes();
                for (int j = 0; j < decryptedBlockBytes.Length; j++)
                    decryptedBytes.Add(decryptedBlockBytes[j]);
            }

            return decryptedBytes.ToArray();
        }
    }
}
