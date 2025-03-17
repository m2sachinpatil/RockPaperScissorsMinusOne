using Domain;

namespace Application
{
  public  interface IGameService
    {
        string DetermineWinner(string hand1, string hand2);
        Round PlayRound(string player1Hand, string player2Hand);
    }
}
