using System;
using System.Collections.Generic;

namespace TicTacToe
{
    enum Piece { X, O }

    class Program
    {
        static void Main(string[] args)  
        {
            Piece? pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9;

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