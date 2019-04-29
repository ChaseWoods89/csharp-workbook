using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 1~~~~~~~~~~~~~~~~~~");  
            int divisibleNumber = 0;
            for(int i = 1; i < 101; i++){
                if (i%3 == 0){
                    divisibleNumber++;
                }
                }
            Console.WriteLine(divisibleNumber + "Is the number of times 3 goes into 100 with no remainder.");   
            Console.WriteLine(" ");

            Console.WriteLine("Press enter to start program 2!");    
            Console.ReadLine();
                        
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 2~~~~~~~~~~~~~~~~~~");  

        
        
        
        }
    }
}
