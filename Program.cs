namespace GitDemonstration
{
    
     
    internal class Program 
    {
        public static void Main(string[] args)
        {
           Program program = new Program();
            program.calculate();
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

        public void calculate()
        {
            Area area = new Area(); 
            area.Calculation();
        }
        

    }
    
}
