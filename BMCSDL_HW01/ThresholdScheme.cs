using Mono.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_HW01
{
    public class ThresholdScheme
    {
        public BigInteger privateKey { get; set; }
        public BigInteger mod { get; set; }
        private int thresHold { get; set; }
        private List<Tuple<BigInteger, BigInteger>> provided { get; set; }
        private List<int> coefficients { get; set; }

        public ThresholdScheme(int thresHold)
        {
            privateKey = BigInteger.GenerateRandom(512);
            mod = BigInteger.GeneratePseudoPrime(512);
            privateKey %= mod;
            this.thresHold = thresHold;
            coefficients = generateCoefficients(thresHold - 1);
            provided = new List<Tuple<BigInteger, BigInteger>>();
        }

        private static List<int> generateCoefficients(int n)
        {
            List<int> result = new List<int>();
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                int rdNum = rd.Next();
                result.Add(rdNum);
            }

            return result;
        }

        public Tuple<BigInteger, BigInteger> provideNewKey()
        {
            Tuple<BigInteger, BigInteger> result;

            BigInteger x = BigInteger.GenerateRandom(512);
            x %= mod;
            while (provided.Exists(item => item.Item1 == x))
            {
                x = BigInteger.GenerateRandom(512);
                x %= mod;
            }

            BigInteger y = privateKey;

            for (int i = 0; i < thresHold - 1; i++)
            {
                y = y + coefficients[i] * x.ModPow(i + 1, mod);
            }

            y = y % mod;
            result = new Tuple<BigInteger, BigInteger>(x, y);

            provided.Add(result);

            return result;
        }

        public BigInteger getKeyFromMembers(List<Tuple<BigInteger, BigInteger>> members)
        {
            BigInteger result = 0;

            for (int i = 0; i < members.Count; i++)
            {
                BigInteger lx = members[i].Item2;
                for (int j = 0; j < members.Count; j++)
                {
                    if ((j != i) && (members[i].Item1 != members[j].Item1))
                    {
                        lx = lx * (((mod - members[j].Item1) * (mod + members[i].Item1 - members[j].Item1).ModInverse(mod)) % mod);
                    }
                }

                result = result + lx;
            }

            result = result % mod;

            return result;
        }
    }
}
