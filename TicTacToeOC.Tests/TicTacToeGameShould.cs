using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace TicTacToeOC.Tests
{
    [TestFixture]
    public class TicTacToeGameShould
    {
        [Test]
        public void BeEqualToAnotherGame_GivenBothHaveNotBeenPlayed()
        {
            var newGame = new TicTacToeGame();
            var otherNewGame = new TicTacToeGame();
            newGame.Should().Be(otherNewGame);
        }
    }

    public class TicTacToeGame
    {
        protected bool Equals(TicTacToeGame other)
        {
            return true;
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
            throw new NotImplementedException();
        }
    }
}
