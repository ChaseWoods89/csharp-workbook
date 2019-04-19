using System;

namespace LoopQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] {5, 12, 4, 10, 22};
            int biggestOneSoFar = Numbers[0];
            for (int idx = 0; idx < Numbers.Length; idx++ )
            {
                int currentNumber = Numbers[idx];
                if( biggestOneSoFar < currentNumber)
                {
                    biggestOneSoFar = currentNumber;
                
                }
            
            }
            Console.WriteLine(biggestOneSoFar);
        }
    }
}
