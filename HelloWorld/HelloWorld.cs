using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hey there, What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + username + ".");
            Console.ReadLine();

            double amount = 389.92;
            int cents = (int) (amount * 100);

            int hundreds = cents/10000;
            cents = cents%10000;

            int fifties = cents / 5000;
            cents = cents%5000;

            int twenties = cents / 2000;
            cents = cents%2000;

            int tens = cents / 1000;
            cents = cents%1000;

            int fives = cents / 500;
            cents = cents%500;
            
            int ones = cents / 100;
            cents = cents%100;

            int quarters = cents / 25;
            cents = cents%25;

            int dimes = cents / 10;
            cents = cents%10;

            int nickels = cents / 5;
            cents = cents%5;

            int pennies = cents;

            


        }
    }
}
