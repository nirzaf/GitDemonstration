using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    public class CountStrings
    {
        public void Word()
        {
            string sentence;
            Console.Write("Enter String  : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words :" + words.Length);
            Console.ReadKey();
        }
    }
}
