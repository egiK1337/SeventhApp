using System.Diagnostics;

namespace SeventhApp
{
    internal class Program
    {
        public static int FibonachiWithRecursion(int n)
        {
            if (n == 0 || n == 1) return n;

            return FibonachiWithRecursion(n - 1) + FibonachiWithRecursion(n - 2);
        }

        static int FibonachiWithСycle(int n)
        {
            int a = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b += temp;
            }

            return a;
        }

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            FibonachiWithRecursion(5);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи рекурсии если n = 5, составляет {stopwatch.Elapsed}мс");

            stopwatch.Start();
            FibonachiWithRecursion(10);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи рекурсии, если n = 10, составляет {stopwatch.Elapsed}мс");

            stopwatch.Start();
            FibonachiWithRecursion(20);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи рекурсии, если n = 20, составляет {stopwatch.Elapsed}мс");

            stopwatch.Start();
            FibonachiWithСycle(5);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи цикла, если n = 5, составляет {stopwatch.Elapsed}мс");

            stopwatch.Start();
            FibonachiWithСycle(10);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи цикла, если n = 10, составляет {stopwatch.Elapsed}мс");

            stopwatch.Start();
            FibonachiWithСycle(20);
            stopwatch.Stop();
            Console.WriteLine($"Расчёт числа фибаначи при помощи цикла, если n = 20, составляет {stopwatch.Elapsed}мс");

        }
    }
}