namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            uint m = n;
            uint i;
            if (m == 0 || m == 1)
            {
                return false;
            }

            for (i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            ulong result = 0;
            for (int i = start; i <= end; i++)
            {
                bool p = true;
                int m = i / 2;
                int j;
                if (i == 0 || i == 1)
                {
                    p = false;
                }

                for (j = 2; j <= m; j++)
                {
                    if (i % j == 0)
                    {
                        p = false;
                    }
                }

                if (p)
                {
                    ulong k = (ulong)i;
                    while (k > 9)
                    {
                        result += k % 10;
                        k /= 10;
                    }

                    result += k;
                }
            }

            return result;
        }
    }
}
