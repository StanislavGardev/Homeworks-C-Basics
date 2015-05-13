using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fib = Fibonacci(num);
            Console.WriteLine("{0}th fiboniacci number is :{1}", num, fib);

        }
        public static int Fibonacci(int number)
        {
            int a = 0;
            int b = 1;
            int fib = 1;
            for (int i = 0; i < number; i++)
            {
                fib = a + b;
                a = b;
                b = fib;

            }

            return fib;
        }
    }
}
