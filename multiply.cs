using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    public class multiply
    {
        public void mul()
        
        {
        float number1, number2, product;

        Console.Write("Enter a number1:");
            number1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a number2:");
            number2 = Convert.ToSingle(Console.ReadLine());
 
            product = number1* number2;

        Console.WriteLine("{0} * {1} = {2}",number1,number2, product);
            Console.ReadLine();
         }
    }
}
