using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class TeamViewModel
    {
        public int Id { get; set; } // id (Primary key)
        public string TeamName { get; set; } // team_name (length: 30)
        public int? RoundWinner { get; set; } // round_winner
        public string ActiveFlag { get; set; } // active_flag (length: 1)
    }
}