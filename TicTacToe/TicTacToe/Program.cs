using System;
using System.Collections.Generic;

namespace TicTacToe
{ 
    static class Program
    {
        static void Main(string[] args)  
        {
            Game game;
            var playAgain = true;
            do {
                var gameOver = false;
                game = new Game();
                do {
                    DrawBoard(game);
                    var winner = game.Winner();
                    if (winner.HasValue) {
                        gameOver = true;
                        if (winner == Piece.X) {
                            Console.WriteLine("X is the winner!");
                        }
                        else {
                            Console.WriteLine("O is the winner!");
                        }
                    }
                    if (!gameOver && game.IsBoardFull) {
                        gameOver = true;
                        Console.WriteLine("It's a tie!");
                    }
                    if (!gameOver) {
                        game.MakeMove(GetMove(game));
                    }
                    else {
                        Console.Write("Play again [y/n]? ");
                        var pa = Console.ReadLine();
                        playAgain = (pa == "y");
                        break;
                    }
                } while (true);
            } while (playAgain);
        }

        static void DrawBoard(Game game)
        {
            Console.WriteLine($" {DrawPiece(game[1])} | {DrawPiece(game[2])} | {DrawPiece(game[3])} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {DrawPiece(game[4])} | {DrawPiece(game[5])} | {DrawPiece(game[6])} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {DrawPiece(game[7])} | {DrawPiece(game[8])} | {DrawPiece(game[9])} ");
        }

        static string DrawPiece(Piece? p) => p switch
        {
            Piece.X => "X",
            Piece.O => "O",
            _ => " ",
        };

        static int GetMove(Game game)
        {
            do {
                Console.Write("Where do you want to move? ");
                string move = Console.ReadLine();

                int m;
                bool isMoveValid = (int.TryParse(move, out m) && m >= 1 && m <= 9);
                isMoveValid = (isMoveValid && !game[m].HasValue);
                if (!isMoveValid) {
                    Console.WriteLine("Invalid move");
                }
                else {
                    return m;
                }
            } while (true);
        }
    }
}
