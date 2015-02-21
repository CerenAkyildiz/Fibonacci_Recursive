using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursive
{
    class Program
    {
        public static Stopwatch watch = new Stopwatch();

        public static long fibonacciRecursive(long girdi)
        {

            if (girdi == 1 || girdi == 2)
            {
                return 1;
            }
            else
                return (fibonacciRecursive(girdi - 1) + fibonacciRecursive(girdi - 2));

        }
        public static void Main(string[] args)
        {

            long deger = 0;
            Console.WriteLine("Kaçıncı fibonacci sayısını hesaplamak istiyorsunuz: ");
            deger = Convert.ToInt32(Console.ReadLine());
            watch.Start();
            Console.WriteLine("{0} . Fibonacci: {1}", deger, fibonacciRecursive(deger));
            watch.Stop();
            Console.WriteLine("Gecen sure: {0} ", watch.Elapsed.ToString());
            Console.ReadLine();

        }

    }

}
