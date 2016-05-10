using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace League.ViewModels
{
    public class DrawViewModel
    {
        public int Id { get; set; } // id (Primary key)
        public int TeamId { get; set; } // team_id
        public int WeekId { get; set; } // week_id
        public int Lane { get; set; } // lane
        public int Pairing { get; set; } // pairing
        public int Game1 { get; set; } // game_1
        public int Game2 { get; set; } // game_2
        public int Game3 { get; set; } // game_3
        public int Series { get; set; } // series
        public int Bonus { get; set; } // bonus
        public int Total { get; set; } // total
        public string LegalLineup { get; set; } // legal_lineup (length: 1)
    }
}