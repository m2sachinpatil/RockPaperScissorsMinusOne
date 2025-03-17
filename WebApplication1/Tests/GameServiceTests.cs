using Application;
using Xunit;

namespace Tests
{
        public class GameServiceTests
        {
            private readonly GameService _gameService;

            public GameServiceTests()
            {
                _gameService = new GameService();
            }

            [Fact]
            public void DetermineWinner_Player1Wins()
            {
                // Arrange
                var player1Hand = "Rock";
                var player2Hand = "Scissors";

                // Act
                var result = _gameService.DetermineWinner(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Player1", result);
            }

            [Fact]
            public void DetermineWinner_Player2Wins()
            {
                // Arrange
                var player1Hand = "Paper";
                var player2Hand = "Scissors";

                // Act
                var result = _gameService.DetermineWinner(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Player2", result);
            }

            [Fact]
            public void DetermineWinner_Draw()
            {
                // Arrange
                var player1Hand = "Rock";
                var player2Hand = "Rock";

                // Act
                var result = _gameService.DetermineWinner(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Draw", result);
            }

            [Fact]
            public void PlayRound_Player1Wins()
            {
                // Arrange
                var player1Hand = "Rock";
                var player2Hand = "Scissors";

                // Act
                var round = _gameService.PlayRound(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Player1", round.Result);
                Assert.Equal(player1Hand, round.Player1Hand);
                Assert.Equal(player2Hand, round.Player2Hand);
            }

            [Fact]
            public void PlayRound_Player2Wins()
            {
                // Arrange
                var player1Hand = "Paper";
                var player2Hand = "Scissors";

                // Act
                var round = _gameService.PlayRound(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Player2", round.Result);
                Assert.Equal(player1Hand, round.Player1Hand);
                Assert.Equal(player2Hand, round.Player2Hand);
            }

            [Fact]
            public void PlayRound_Draw()
            {
                // Arrange
                var player1Hand = "Rock";
                var player2Hand = "Rock";

                // Act
                var round = _gameService.PlayRound(player1Hand, player2Hand);

                // Assert
                Assert.Equal("Draw", round.Result);
                Assert.Equal(player1Hand, round.Player1Hand);
                Assert.Equal(player2Hand, round.Player2Hand);
            }
        }
    }

