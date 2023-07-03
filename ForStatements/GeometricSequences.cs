namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong result = 1;
            ulong i = 0;
            for (i = 0; i < n; i++)
            {
                ulong rpow = 1;
                for (ulong j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                result *= a * rpow;
            }

            return result;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            ulong sum = 0;
            double i = 0;
            for (i = 0; i < n; i++)
            {
                double vIn = Math.Pow(3, i);
                uint vOut = Convert.ToUInt32(vIn);
                sum += 5 * vOut;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong sum = a;
            ulong i = 1;
            if (maxTerm < a)
            {
                return 0;
            }

            for (i = 1; a * r <= maxTerm; i++)
            {
                a *= r;
                sum += a;
            }

            return i;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            ulong i = 0;
            for (; n > 0; n--)
            {
                if (a >= minTerm)
                {
                    i++;
                }

                a *= r;
            }

            return i;
        }
    }
}
