using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Round
    {
        public Guid Id { get; set; }
        public string Player1Hand { get; set; }
        public string Player2Hand { get; set; }
        public string Result { get; set; } // Win, Lose, Draw
    }
}
