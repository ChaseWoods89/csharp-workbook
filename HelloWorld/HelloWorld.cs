﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there stranger, what's your name?");
            String userName = Console.ReadLine();
            Console.WriteLine("Well, pleasure to meet you " + userName + ". My Name is Chase!");
            Console.ReadLine();
        }
    }
}
