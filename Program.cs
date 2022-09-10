namespace GitDemonstration;

internal class Program
{
    
    static void Main(string[] args)
    {
        public static void Main(string[] args)
        {

           Program program = new Program();
            program.calculate();

            Rectangle R = new Rectangle();
            R.Area();

            Avg avg = new Avg();
            avg.average();

            multiply mult = new multiply();
            mult.mul();

            CountStrings obj = new CountStrings();
            obj.Word();

            FindEvenOrOdd findEvenOrOdd = new FindEvenOrOdd();
            findEvenOrOdd.Main();
        }
    }

   
         public void calculate()
        {
            Area area = new Area(); 
            area.Calculation();
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


class Dog
{
    string breed;

    public void bark()
    {

    }
}