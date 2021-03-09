using System;

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

            Console.Write("Where do you want to move? ");
            string move = Console.ReadLine();

            int m;
            bool b = int.TryParse(move, out m);



            Console.ReadKey();
        }
    }
}