using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Winner { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Round> Rounds { get; set; } = new();
    }
}
