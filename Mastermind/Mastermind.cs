using System;
using System.Collections.Generic;

namespace Mastermind {
    class Program {
        static void Main (string[] args) {
            Game game = new Game (new string[] { "a", "b", "c", "d" });
            for (int turns = 10; turns > 0; turns--) {
                Console.WriteLine($"You have {turns} tries left");
                Console.WriteLine ("Choose four letters: ");
                string letters = Console.ReadLine ();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++) {
                    balls[i] = new Ball (letters[i].ToString());
                }
                Row row = new Row (balls);
                game.AddRow (row);
                Console.WriteLine (game.Rows);
            }
            Console.WriteLine ("Out Of Turns");
        }
    }

    class Ball {
        //this class establishes the "balls" (Strings that will be placed in rows (arrays))
        String orangeBall = "Orange";
        String blueBall = "Blue";
        String greenBall = "Green";
        String purpleBall = "Purple";

        String yellowBall = "Yellow";
        String pinkBall = "Pink";
    }

    class Row {
        //this class establishes the "Rows" (Arrays which strings are placed)
       public string [] masterRow = {"","","",""};
        public string [] firstRowGuess = {"","","",""};
        public string [] secondRowGuess = {"","","",""};
        public string [] thirdRowGuess = {"","","",""};
        public string [] fourthRowGuess = {"","","",""};

    }

    class Game {
        //this class establishes game logic/rules
        //need to make logic work, not sure how. essentially
        //if any row of guesses equal masterRow, the player wins.

        PlayGame(){

        if(firstRowGuess == masterRow){

        }

        }
        

    }

}