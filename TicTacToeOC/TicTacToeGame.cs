using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeOC
{
    public class TicTacToeGame
    {
        private int playedMoves = 0;
        private Position currentPosition;
        private readonly List<Position> playedPositions = new List<Position>();

        protected bool Equals(TicTacToeGame other)
        {
            return playedMoves == other.playedMoves 
                && currentPosition == other.currentPosition
                && playedPositions.SequenceEqual(other.playedPositions);
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
                var hashCode = playedMoves;
                hashCode = (hashCode*397) ^ (int) currentPosition;
                hashCode = (hashCode*397) ^ (playedPositions != null ? playedPositions.GetHashCode() : 0);
                return hashCode;
            }
        }

        public void Play(Position position)
        {
            currentPosition = position;
            playedMoves += 1;
            playedPositions.Add(position);
        }
    }
}