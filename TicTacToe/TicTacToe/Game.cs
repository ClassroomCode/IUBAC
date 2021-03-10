using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Piece { X, O }

    public class Game
    {
        private Piece?[] _board;
        private Piece _currentPlayer;

        public Game()
        {
            _board = new Piece?[9];
            _currentPlayer = Piece.X;
        }

        public Piece? this[int i]
        {
            get { return _board[i - 1]; }
            private set { _board[i - 1] = value; }
        }

        public bool MakeMove(int i)
        {
            if (this[i].HasValue) return false;

            this[i] = _currentPlayer;
            _currentPlayer = (_currentPlayer == Piece.X ? Piece.O : Piece.X);
            return true;
        }

        public bool IsBoardFull => _board.All(p => p.HasValue);

        public Piece? Winner()
        {
            if (Winner(1, 2, 3) != null) return Winner(1, 2, 3);
            if (Winner(4, 5, 6) != null) return Winner(4, 5, 6);
            if (Winner(7, 8, 9) != null) return Winner(7, 8, 9);
            if (Winner(1, 4, 7) != null) return Winner(1, 4, 7);
            if (Winner(2, 5, 8) != null) return Winner(2, 5, 8);
            if (Winner(3, 6, 9) != null) return Winner(3, 6, 9);
            if (Winner(1, 5, 9) != null) return Winner(1, 5, 9);
            if (Winner(3, 5, 7) != null) return Winner(3, 5, 7);
            return null;
        }

        private Piece? Winner(int p1, int p2, int p3)
        {
            if (!this[p1].HasValue) return null;
            if (this[p1] == this[p2] && this[p2] == this[p3]) return this[p1];
            return null;
        }
    }
}
