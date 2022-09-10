namespace GitDemonstration
{
    public class ReverseNo
    {
        public void print_revers_no()
        {
            Console.WriteLine("Enter a no to revers: ");
            
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (number>0)
            {
                int reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine("Revers No is : " , reverse);
            Console.ReadLine();
        }
    
    }
}

