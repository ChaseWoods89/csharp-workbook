using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
             if (hand1 == hand2){
              return "It's a tie.";}
        

            else if (hand1 == "rock" && hand2 == "scissors"){
              return "Hand 1 Wins!!!";
            }
			
			else if (hand1 == "scissors" && hand2 == "paper"){
				return "Hand 1 Wins!!!";
			}
			
			else if (hand1 == "paper" && hand2 == "rock"){
				return "Hand 1 Wins!!!";
			}
            
			else {	
                return "Hand 2 Wins!!!";
                }
        }
    }
}
