namespace GitDemonstration;

internal class Program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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