namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            int sum;
            int x1 = 0;
            int x2 = 1;
            for (int i = 0; i < n; i++)
            {
                sum = x1 + x2;
                x1 = x2;
                x2 = sum;
            }

            return x1;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            ulong sum;
            ulong x1 = 0;
            ulong x2 = 1;
            for (ulong i = 0; i < n; i++)
            {
                sum = x1 + x2;
                x1 = x2;
                x2 = sum;
            }

            ulong digits = 1;
            while (x1 > 9)
            {
                digits *= x1 % 10;
                x1 /= 10;
            }

            digits *= x1;
            return digits;
        }
    }
}
