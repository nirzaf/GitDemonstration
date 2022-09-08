using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    internal class Area
    {

        
        
        public void Calculation()
        {
             static int calculateArea(int lengthInFeets, int widthInFeets)
            {
                return (lengthInFeets * widthInFeets);
            }

            int lengthInFeets = 0;
            int widthInFeets = 0;
            int plotArea = 0;


            Console.Write("Enter length of the plot in feets: ");
            lengthInFeets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width of room in feet:");
            widthInFeets = Convert.ToInt32(Console.ReadLine());

            plotArea = calculateArea(lengthInFeets, widthInFeets);

            Console.WriteLine("Plot area is " + plotArea + " square feet");
            Console.ReadKey();

            Console.WriteLine("Calculate Area and Perimeter of Square");
            int s, area, perimeter;
            Console.Write("Side length : ");
            s = Convert.ToInt32(Console.ReadLine());
            area = 4 * s;
            perimeter = s * s;
            Console.WriteLine("Area of Square : " + area);
            Console.WriteLine("Perimeter of Square : " + perimeter);
            Console.ReadKey();
        }
    }
        
}
