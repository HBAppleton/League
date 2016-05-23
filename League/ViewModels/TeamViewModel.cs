using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class TeamViewModel
    {
        public int Id { get; set; } // id (Primary key)

        [Display(Name ="Team Name")]
        [StringLength(30)]
        [Required]
        public string TeamName { get; set; } // team_name (length: 30)

        [Display(Name = "Winner Round")]
        [Range(0, 4)]
        [Required]
        public int? RoundWinner { get; set; } // round_winner

        [Display(Name = "Active")]
        [StringLength(1)]
        [RegularExpression("[YyNn]", ErrorMessage = "Must be Y or N.")]
        [Required]
        public string ActiveFlag { get; set; } // active_flag (length: 1)
    }
}