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

        [Test]
        public void BeDifferentToAnUnstartedGame_GivenAMoveHasBeenPlayed()
        {
            var startedGame = new TicTacToeGame();
            startedGame.Play(Position.TopLeft);
            var newGame = new TicTacToeGame();
            
            startedGame.Should().NotBe(newGame);
        }
    }
}
