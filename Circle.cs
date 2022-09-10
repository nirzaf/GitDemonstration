using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    internal class Circle
    {
        double r, area;
        double PI = 3.14;

        public void CircleArea()
        {

            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            area = PI * r * r;
            Console.WriteLine("The area of yor circle : {0}", area);
        }
    }
}
