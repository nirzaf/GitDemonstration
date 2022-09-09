namespace GitDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            multiply mult = new multiply();
            mult.mul();

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
}
