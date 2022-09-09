using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    public class Student
    {
        public string Name;
        public int Age;
        public string Subject;

        public void Greeting()
        {
            Console.WriteLine("Hi! My Name is " + Name + ", My Age is " + Age + " and My Favourite Subject is " + Subject);
        }
    }
}
