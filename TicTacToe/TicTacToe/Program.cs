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

            bool isMoveValid = false;
            do
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine("---+---+---");
                Console.WriteLine("   |   |   ");
                Console.WriteLine("---+---+---");
                Console.WriteLine("   |   |   ");

                Console.Write("Where do you want to move? ");
                string move = Console.ReadLine();

                int m;
                isMoveValid = (int.TryParse(move, out m) && m >= 1 && m <= 9);
                if (!isMoveValid) Console.WriteLine("Invalid move");        
            } while (!isMoveValid);

            // make move and change player
        }
    }
}