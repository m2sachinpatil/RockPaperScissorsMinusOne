using Application;
using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Hubs
{
    public class GameHub : Hub
    {
        private readonly GameService _gameService;

        public GameHub(GameService gameService)
        {
            _gameService = gameService;
        }

        public async Task SubmitHand(string player, string hand)
        {
            await Clients.Others.SendAsync("ReceiveHand", player, hand);
        }

        public async Task ResolveRound(string player1Hand, string player2Hand)
        {
            var round = _gameService.PlayRound(player1Hand, player2Hand);
            await Clients.All.SendAsync("RoundResult", round);
        }
    }
}
