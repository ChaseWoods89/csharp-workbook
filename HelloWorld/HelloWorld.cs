using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumberOneInput;
            string NumberTwoInput;

            Console.WriteLine("First number?");
            NumberOneInput = Console.ReadLine();
            Console.WriteLine("Second number?");
            NumberTwoInput = Console.ReadLine();

            int NumberOne = Convert.ToInt32(NumberOneInput);
            int NumberTwo = Convert.ToInt32(NumberTwoInput);

            Console.WriteLine("Your Number is " + (NumberOne + NumberTwo));

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("How many yards are you measuring?");
            string yardsInput = Console.ReadLine();

            int Yards = Convert.ToInt32(yardsInput);
            int Inches = Yards*36;

            Console.WriteLine("There are " + Inches + " inches in " + Yards + "."); 



        }
    }
}
