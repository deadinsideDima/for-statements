namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            long term = 0;
            uint i = 1;
            for (i = 1; term < maxTerm; i++)
            {
                term = (a * i * i) + (b * i) + c;
            }

            if (i > 0)
            {
                return i - 1;
            }
            else
            {
                return 0;
            }
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            ulong a = 7;
            ulong b = 4;
            ulong c = 2;
            ulong j = 1;
            ulong product = 1;
            for (ulong i = 1; i <= count; i++)
            {
                ulong term = (a * j * j) + (b * j) + c;
                product *= term;
                j++;
            }

            return product;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong product = 1;
            for (long i = 1; i <= count; i++)
            {
                ulong term = (ulong)((a * startN * startN) + (b * startN) + c);
                product *= term;
                startN++;
            }

            return product;
        }
    }
}
