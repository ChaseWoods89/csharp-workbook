using System;
using System.Collections.Generic;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>{};
            int i = 0;
            for(i = 0; i < 6; i++){
            Console.WriteLine("Give me a number!");
            string input = Console.ReadLine();
            try{
            int number = Convert.ToInt32(input);
            numbers.Add(number);}
            catch(Exception E){
                Console.WriteLine(E.Message);
            }
            
            
                
            

            

            
        }
    }
    }
}

