using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            privateKey = getRandom();
            mod = randomBigPrime();
            privateKey %= mod;
            this.thresHold = thresHold;
            coefficients = generateCoefficients(thresHold - 1);
            provided = new List<Tuple<BigInteger, BigInteger>>();
        }

        private static BigInteger getRandom()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            byte[] data = new byte[64];

            rd.NextBytes(data);

            BigInteger result = new BigInteger(data);

            if (result.Sign == -1)
                result = result * -1;

            return result;
        }

        private static BigInteger randomBigPrime()
        {
            BigInteger n = getRandom();
            if (n % 2 == 0)
                n++;

            while (!isPrime(n))
            {
                n = getRandom();
                if (n % 2 == 0)
                    n++;
            }

            return n;
        }

        // Using Miler - Rabin test.
        private static bool isPrime(BigInteger n)
        {
            BigInteger m = n - 1;
            BigInteger s = 0;
            while (m % 2 == 0)
            {
                s++;
                m >>= 1;
            }
            BigInteger a = getRandom();
            a %= n;
            while (a < 2)
            {
                a = getRandom();
                a %= n;
            }

            BigInteger b = BigInteger.ModPow(a, m, n);

            if (b == 1)
                return true;

            for (BigInteger i = 0; i < s; i++)
            {
                if (b == n - 1)
                    return true;
                b = BigInteger.ModPow(b, 2, n);
            }

            return false;
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

        private static BigInteger gcd(BigInteger a, BigInteger b)
        {
            if (a == 0)
                throw new Exception("Can't find gcd with zero.");

            if (a.Sign == -1)
                a = a % b;

            BigInteger r;
            while (b > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        private static BigInteger modInverse(BigInteger value, BigInteger mod)
        {
            if (gcd(value, mod) != BigInteger.One)
                throw new Exception("Can't find the inverse with 2 numbers not coprime.");

            BigInteger xa = BigInteger.One;
            BigInteger xm = BigInteger.Zero;
            BigInteger q, xr, r;

            while (mod > 0)
            {
                q = value / mod;
                xr = xa - q * xm;
                xa = xm;
                xm = xr;
                r = value % mod;
                value = mod;
                mod = r;
            }

            return xa;
        }

        public Tuple<BigInteger, BigInteger> provideNewKey()
        {
            Tuple<BigInteger, BigInteger> result;

            BigInteger x = getRandom();
            while (provided.Exists(item => item.Item1 == x))
                x = getRandom();
            BigInteger y = privateKey;

            for (int i = 0; i < thresHold - 1; i++)
            {
                y = y + coefficients[i] * BigInteger.ModPow(x, i + 1, mod);
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
                        lx = lx * (((-members[j].Item1) / (modInverse(members[i].Item1 - members[j].Item1, mod))) % mod);
                    }
                }

                result = result + lx;
            }

            result = result % mod;

            return result;
        }
    }
}
