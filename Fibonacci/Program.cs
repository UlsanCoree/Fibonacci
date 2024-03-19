namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(11));
            Console.WriteLine(FibonacciForLoop(11));
        }

        public static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static int FibonacciForLoop(int n)
        {
            if (n < 2)
            {
                return n;
            }

            int a = 0;
            int b = 1;
            int temp = 0;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
