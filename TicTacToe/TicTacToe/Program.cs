using System;
using System.Collections.Generic;

namespace TicTacToe
{
    static class Program
    {
        static void Main(string[] args)  
        {
            var board = new Piece?[9]; 

            var currentPlayer = Piece.X;

            do DrawBoard(); while (!MakeMove());

            // make move and change player
        }

        static void DrawBoard()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
        }

        static bool MakeMove()
        {
            Console.Write("Where do you want to move? ");
            string move = Console.ReadLine();

            int m;
            bool isMoveValid = (int.TryParse(move, out m) && m >= 1 && m <= 9);
            if (!isMoveValid) Console.WriteLine("Invalid move");
            return isMoveValid;
        }
    }
}

/* LAB

1) Define a public class named Game (Game.cs)
2) Define a private field for the board and the current player
3) Move definition of Piece into Game.cs
4) Define a constructor that inits board and current player
5) Provide a way to get the piece in a position
6) Provide a method to make a move (take a position and update the board)
7) Provide a way to ask if the board is full

8) BONUS *** Define a method that will return if there is a winner
 */
