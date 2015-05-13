using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Difference_between_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Parse(Console.ReadLine());
            DateTime b= DateTime.Parse(Console.ReadLine());
            TimeSpan t = a - b;
            double NrOfDays = t.TotalDays;
           // TimeSpan diff = b.Subtract(a);
            Console.WriteLine(NrOfDays);



        }
    }
}
