namespace GitDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Concate c = new Concate();
            c.concate();

        }

        public string ConvertToUpperCase(string name)
        {
            return name.ToUpper();
        }

        public string ConvertIntToString(int input)
        {
            return input.ToString();
        }

        public void NewMethod()
        {
            Console.WriteLine("NewMethod Added");
        }

        public void AddSecondNewMethod()
        {
            Console.WriteLine("AddSecondNewMethod");
        }

    }

    // C# program to illustrate the use
    // of Concat(String, String ) Method
    public class Concate
    {
        public void concate()
        {
            string strA = "Hello!";
            string strB = "World.";
            string str;

            // print all strings
            Console.WriteLine("String A is:{0} ", strA);
            Console.WriteLine("String B is:{0} ", strB);

            // Concatenate two different strings
            // into a single String
            // using Concat(String, String ) Method

            str = String.Concat(strA, strB);

            Console.WriteLine("Concatenated string is:{0}", str);

        }
    }
}

  


