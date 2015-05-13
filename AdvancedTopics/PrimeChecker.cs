using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
           long n = long.Parse(Console.ReadLine());
            bool prime = IsPrime(n);
            Console.WriteLine("{0} {1}", n, prime);
        }

        static bool IsPrime(long prime) 
        {
            if (prime==1||prime==0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < prime/2; i++)
                {
                    if (prime%i==0)
                    {
                        return false;
                    }
                    
                }
                return true;
            }
           
           
        }
    }
}
