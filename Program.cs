namespace GitDemonstration;

internal class Program
{
    
    static void Main(string[] args)
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Concate c = new Concate();
            c.concate();

            Program myProgram = new Program();
            myProgram.revers_no();

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


        public void NewMethod()
        {
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

        public void revers_no()
        {
            ReverseNo a1 = new ReverseNo();
            a1.print_revers_no();
        }

    public string ConvertIntToString(int input)
    {
        return input.ToString();
    }
        
    public void NewMethod()
    {
        Console.WriteLine("NewMethod Added");
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

