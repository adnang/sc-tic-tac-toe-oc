using FluentAssertions;
using NUnit.Framework;

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
        
        [Test]
        public void BeDifferentToGamePlayedAtTopRight_GivePlayedAtTopLeft()
        {
            var topLeftGame = new TicTacToeGame();
            topLeftGame.Play(Position.TopLeft);
            var topRightGame = new TicTacToeGame();
            topRightGame.Play(Position.TopRight);

            topLeftGame.Should().NotBe(topRightGame);
        }

        [Test]
        public void BeDifferentToGameWithSameLastPlay_GivenStartedDifferently()
        {
            var game = new TicTacToeGame();
            var differentGame = new TicTacToeGame();
            game.Play(Position.TopLeft);
            differentGame.Play(Position.TopMiddle);
            game.Play(Position.CenterLeft);
            differentGame.Play(Position.CenterLeft);

            game.Should().NotBe(differentGame);
        }
    }
}
