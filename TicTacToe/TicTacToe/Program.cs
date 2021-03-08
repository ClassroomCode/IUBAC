using System;
using System.Text;

namespace TicTacToe
{
    enum Piece { X, O }

    class Program
    {
        static void Main(string[] args)  
        {
            Piece? pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9;

            Piece currentPlayer = Piece.X;

            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
        }
    }
}

// LAB 1
// 1) Define a type to represent a piece (enum)
// 2) Define a variable for each position
// 3) Define a variable for the current player
