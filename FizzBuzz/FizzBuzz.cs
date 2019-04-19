using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like a For Loop(1) or a While Loop(2)? (please type 1 or 2)");
            string userInput = Console.ReadLine();
            int option = Convert.ToInt32(userInput);

            if(option == 1){
                Console.WriteLine("Here is the For Loop");
                ForLoop();
            }
            else if(option == 2){
                Console.WriteLine("Here is your While Loop");
                WhileLoop();
            }
        }
        static void ForLoop(){
        for(int i = 1; i <= 100; i++)  
        {  
        if (i % 3 == 0 && i % 5 == 0)  
        {  
            Console.WriteLine("FizzBuzz");  
        }  
        else if (i % 5 == 0)  
        {  
           Console.WriteLine("Buzz");  
        }  
        else if (i % 3 == 0)  
        {  
           Console.WriteLine("Fizz");  
        }  
        else  
        {  
            Console.WriteLine(i);  
        }
        }
        }

        static void WhileLoop()
        {
        int num = 1;
        while(num <= 100)
        {
            if(num%3 == 0 && num%5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                num++;
            }
            else if (num%5 == 0)
            {
                Console.WriteLine("Buzz");
                num++;
            }
            else if (num%3 == 0)
            {
                Console.WriteLine("Fizz");
                num++;
            }
            else {
                Console.WriteLine(num);
                num++;
                
            }

            
        }

    }
        }
    }

    
    

