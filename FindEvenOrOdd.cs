using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    public class FindEvenOrOdd
    {
        public void Main()
        {
            int n;
            Console.Write("Enter an integer : ");

            n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is even", n);
            }
            else
            {
                Console.WriteLine("{0} is odd", n);
            }
            Console.ReadKey();
        }
    }
}
