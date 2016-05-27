using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class VdrawViewModel
    {
        public int Season { get; set; } // season
        public int Round { get; set; } // round

        [Display(Name ="Week")]
        public int? RoundWeek { get; set; } // round_week

        public int Lane { get; set; } // lane

        [Display(Name ="Team Name")]
        public string TeamName { get; set; } // team_name (length: 30)
        public int Game1 { get; set; } // game_1
        public int Game2 { get; set; } // game_2
        public int Game3 { get; set; } // game_3
        public int Series { get; set; } // series
        public int Bonus { get; set; } // bonus
        public int Total { get; set; } // total

        [Display(Name = "Legal")]
        [StringLength(1)]
        [RegularExpression("[YyNn]", ErrorMessage = "Must be Y or N.")]
        public string LegalLineup { get; set; } // legal_lineup (length: 1)


        public int Id { get; set; } // draw_id
        public int WeekId { get; set; } // week_id
        public int TeamId { get; set; } // team_id
    }
}