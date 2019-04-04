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
        }
    }
}
