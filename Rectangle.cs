using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    public class Rectangle
    {
        int area, length, width;

        public void Area()
        {
            Console.WriteLine("Please write the length of your rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the width of your rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("The area of rectangle : {0}", area);
            Console.ReadKey();
        }
       
    }
}
