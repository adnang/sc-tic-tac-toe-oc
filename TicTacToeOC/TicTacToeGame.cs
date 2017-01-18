using System;

namespace TicTacToeOC
{
    public class TicTacToeGame
    {
        private int playedMoves = 0;

        protected bool Equals(TicTacToeGame other)
        {
            return playedMoves == other.playedMoves;
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
            return playedMoves;
        }

        public void Play(Position position)
        {
            playedMoves += 1;
        }
    }
}