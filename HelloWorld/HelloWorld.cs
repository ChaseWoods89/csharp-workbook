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

            Console.WriteLine("--------------------------------------");


            var people = true;
            var f = false;
            double num = 2.5;

            Console.WriteLine( num + " times itself is " + num*num);

            Console.WriteLine("--------------------------------------");

            string firstName = "Chase";
            string lastName = "Woods";
            int age = 29;
            string job = "Lyft Driver";
            string favoriteBand = "Animals As Leaders";
            string favoriteSportsTeam = " the Tampa Bay Lightning, Dallas Cowboys, Kentucky Wildcats in no particular order.";

            Console.WriteLine("Hey there! My name is " + firstName + " " + lastName + ". I am " + age + " years old and I am a " + job + ". My favorite band right now is " + favoriteBand + ", they are awesome and you should check them out. My favorite sports teams are " + favoriteSportsTeam + ", The Lightning are totally winning the Stanley Cup! Go Bolts!");

            Console.WriteLine("--------------------------------------");




        }
    }
}
