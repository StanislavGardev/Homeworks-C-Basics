using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            FindPrimesInRange(a, b);
        }
        static List<int> FindPrimesInRange( int startNum,  int endNum)
        {
            List<int> prime =new List<int>();
            for (int num = startNum; num <= endNum ; num++)
            {
                
                {
                    if (IsPrime(num))
                    {
                        Console.Write("{0}, ",num);
                        prime.Add(num);
                            

                    }
                }
               

            }
            return prime;
           
        }
        static bool IsPrime(long prime)
        {
            if (prime == 1 || prime == 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Floor(Math.Sqrt(prime)); i++)
                {
                    if (prime % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }


        }
    }
}
