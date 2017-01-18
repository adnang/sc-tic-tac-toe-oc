using System;

namespace TicTacToeOC
{
    public class TicTacToeGame
    {
        private int playedMoves = 0;
        private Position position;

        protected bool Equals(TicTacToeGame other)
        {
            return playedMoves == other.playedMoves && position == other.position;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TicTacToeGame) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (playedMoves*397) ^ (int) position;
            }
        }

        public void Play(Position position)
        {
            this.position = position;
            playedMoves += 1;
        }
    }
}