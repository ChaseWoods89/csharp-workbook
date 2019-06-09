using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
        }
    }

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
             if (Color == "white")
            {
                int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                string openCircle = char.ConvertFromUtf32(openCircleId);
                Symbol = openCircle;
            }
            else
            {
                int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                string closedCircle = char.ConvertFromUtf32(closedCircleId);
                Symbol = closedCircle;
            }
        }
    }

    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board() //should not console to the screen
        {
            Checkers = new List<Checker>();

            return;
        }
        
        public void CreateBoard()
        {
                Grid = new string[][]{
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "},
                new string[]{" "," "," "," "," "," "," "," "}

            };
        
            return;
        }
        
       
       public void GenerateCheckers() 
       //This function drove me insane, essentially it needed to create two diferent string arrays 
       //whitePostitions and blackPositions. These were to house the vertices which the checkers would be placed
       //however I could never find a clear answer on what exactly I had done wrong here.
        {
            string [][] whitePositions = new string[][]; 
            whitePositions =  [0,1] [0, 3], [0, 5], [0, 7],
                              [1, 0], [1, 2], [1, 4], [1, 6],
                              [2, 1], [2, 3], [2, 5], [2, 7]
            string [][] blackPositions = new string[][]; 
            blackPositions = [5, 0], [5, 2], [5, 4], [5, 6],
                             [6, 1], [6, 3], [6, 5], [6, 7],
                             [7, 0], [7, 2], [7, 4], [7, 6]

            return;
        }
        
        
        public void PlaceCheckers()
        {
            // I didn't get a chance to work on this, but I assumed that it would be if checker.color == black place
            //that checker with coordinated symbol on vertices from blackPositions and vice versa.
            return;
        }
        
        public void DrawBoard()
        //Using the template from tictactoe, I tried to create the board, however for some reason, it wouldn't work
        //once again I simply couldn't find an answer to why grid wasn't a viable answer as it was done exactly as it was in
        //tictactoe, but kept having errors thrown
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            Console.WriteLine("0 " + String.Join("|", Grid[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", Grid[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", Grid[2]));
            Console.WriteLine("  -----");
            Console.WriteLine("3 " + String.Join("|", Grid[3]));
            Console.WriteLine("  -----");
            Console.WriteLine("4 " + String.Join("|", Grid[4]));
            Console.WriteLine("  -----");
            Console.WriteLine("5 " + String.Join("|", Grid[5]));
            Console.WriteLine("  -----");
            Console.WriteLine("6 " + String.Join("|", Grid[6]));
            Console.WriteLine("  -----");
            Console.WriteLine("7 " + String.Join("|", Grid[7]));
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(int row, int column)
        {//if move 2,2 || -2,2 || -2, -2 ||2,-2 then remove that piece
            // Your code here
            return;
        }
        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            Board board = new Board();
            board.DrawBoard();
            Console.ReadLine();
        }
        public bool IsLegalMove()
        {//can always return true!
            return true;
        }
    }
}
