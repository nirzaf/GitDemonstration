namespace GitDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program myProgram = new Program();
            myProgram.revers_no();
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

        public void revers_no()
        {
            ReverseNo a1 = new ReverseNo();
            a1.print_revers_no();
        }

    }
}
