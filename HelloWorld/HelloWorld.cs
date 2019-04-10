using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            string userNumberInput = Console.ReadLine();

             int userNumber = Convert.ToInt32(userNumberInput);

             if ( userNumber > 0)
             {
                 Console.WriteLine(userNumber + " is a positive number!");
             }
             else if ( userNumber < 0)
             {
                 Console.WriteLine(userNumber + " is a negative number!");
             }
             else
             {
                 Console.WriteLine("You have enter zero. Cool.");
             }

             Console.ReadLine();

        }
    }
}
