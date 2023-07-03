namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            return product;
        }

        public static int SumFactorialDigits(int n)
        {
            int sum = 0;
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            for (; product > 0; product /= 10)
            {
                sum += product % 10;
            }

            return sum;
        }
    }
}
