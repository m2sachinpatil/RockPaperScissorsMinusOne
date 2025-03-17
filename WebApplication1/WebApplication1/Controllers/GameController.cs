using Application;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("play")]
        public IActionResult PlayRound([FromBody] RoundRequest request)
        {
            var round = _gameService.PlayRound(request.Player1Hand, request.Player2Hand);
            return Ok(round);
        }
    }

    public class RoundRequest
    {
        public string Player1Hand { get; set; }
        public string Player2Hand { get; set; }
    }
}
