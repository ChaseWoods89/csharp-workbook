using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            /*  any consonants before first vowel get moved to end
                if updated word ends in vowel add "yay"
                if word ends in consonant add "ay"
                fox -> oxfay
                tsk -> tskay
                are -> areyay
                mine -> inemay
                thing -> ingthay
                extra credit treat y as vowel when in middle of word
                treat y as consonant
            */

            Console.WriteLine("I convert words to pig latin, what word would you like me to translate?");
            string userInput = Console.ReadLine().ToLower();

            char [] vowels = {'a', 'e','i','o','u'};

            int firstVowelIndex = userInput.IndexOfAny(vowels);
            int lastVowelIndex = userInput.LastIndexOf(vowels);

            string firstPart = userInput.Substring(0,firstVowelIndex);
            string secondPart = userInput.Substring(firstVowelIndex);

            if (lastVowelIndex == 1)
            {
                
            }

            Console.WriteLine(secondPart + firstPart + "ay");
            

            //leave this command
            Console.ReadLine();
        }
        
    }
}
