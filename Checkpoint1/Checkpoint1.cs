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
            Console.WriteLine(divisibleNumber + " Is the number of times 3 goes into 100 with no remainder.");   
            Console.WriteLine(" ");

            Console.WriteLine("Press enter to start program 2!");    
            Console.ReadLine();
                        
          
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 2~~~~~~~~~~~~~~~~~~"); 
            
            
            var sum = 0;
            while(true){
                Console.WriteLine("Please enter a number or 'ok' to exit");
                string numberInput = Console.ReadLine().ToLower();
                

                if( numberInput == "ok" ){
                    break;
                    
                }
                sum += Convert.ToInt32(numberInput);

            }
                    Console.WriteLine("The sum of your numbers is " + sum );

            Console.WriteLine("Press enter to start program 3!");    
            Console.ReadLine(); 
            
      
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 3~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Give me a number and I will give you it's factorial!");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);
            int factorial = userInt;
            for(int i = userInt -1; i >= 1; i--){
                    factorial = factorial * i;
            }

            Console.WriteLine(userInt + "! = " + factorial);


            Console.WriteLine("Press enter to start program 4!");    
            Console.ReadLine();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 4~~~~~~~~~~~~~~~~~~");  

            Random randomInt = new Random();
            int randomNumber = randomInt.Next(1,10);
            int winningNumber = randomNumber;
            
            
            for(int i = 0; i < 4; i++){
            Console.WriteLine("Guess a number 1-10!");
            int userNumber = int.Parse(Console.ReadLine());
            if( winningNumber == userNumber){
                Console.WriteLine("You guessed right, congratulations!");
                i=4;
            }
            else if( i >= 3){
                Console.WriteLine("The number we were looking for was " + winningNumber + ". Sorry, you lose!");
            }
            }
            Console.WriteLine("Press enter to start program 5!");    
            Console.ReadLine();
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Program 5~~~~~~~~~~~~~~~~~~");  
            //Was having an issue with this one where it works sometimes 
            //than other times it will throw an out of bounds exception
            Console.WriteLine("Please enter a series of numbers separated by a comma (,).");
            string userString = Console.ReadLine();
            string [] noComma = userString.Split(',');
            int [] numberArray = Array.ConvertAll(noComma, int.Parse);
            int currentNumber = 0;
            for(int i = 0; i < numberArray.Length; i++){
                if(currentNumber < numberArray[i]){
                    currentNumber = numberArray[i];
                }
                
            }
            Console.WriteLine("Your highest number is " + currentNumber);

            Console.WriteLine("Press enter to exit all programs, thank you!");    
            Console.ReadLine();
  
        
        }
    }
}
