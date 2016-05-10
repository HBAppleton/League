using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class TeamNoteViewModel
    {
        public int Id { get; set; } // id (Primary key)
        public int TeamId { get; set; } // team_id
        public int Season { get; set; } // season
        public string Note { get; set; } // note
        public int? Rank { get; set; } // rank
    }
}