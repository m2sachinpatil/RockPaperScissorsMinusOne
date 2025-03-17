using Domain;

namespace Application
{
    public class GameService : IGameService
    {
        public string DetermineWinner(string hand1, string hand2)
        {
            if (hand1 == hand2) return "Draw";
            if ((hand1 == "Rock" && hand2 == "Scissors") ||
                (hand1 == "Paper" && hand2 == "Rock") ||
                (hand1 == "Scissors" && hand2 == "Paper"))
            {
                return "Player1";
            }
            return "Player2";
        }

        public Round PlayRound(string player1Hand, string player2Hand)
        {
            var result = DetermineWinner(player1Hand, player2Hand);
            return new Round
            {
                Player1Hand = player1Hand,
                Player2Hand = player2Hand,
                Result = result
            };
        }
    }
}
