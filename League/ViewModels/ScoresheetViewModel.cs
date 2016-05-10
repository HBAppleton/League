using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class ScoresheetViewModel
    {
        public int Id { get; set; } // id (Primary key)
        public int BowlerId { get; set; } // bowler_id
        public int DrawId { get; set; } // draw_id
        public string BlindScore { get; set; } // blind_score (length: 1)
        public int Handicap { get; set; } // handicap
        public int Game1 { get; set; } // game_1
        public int Game2 { get; set; } // game_2
        public int Game3 { get; set; } // game_3
    }
}