using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class BowlerViewModel
    {
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Bowler Name")]
        [Required]
        [StringLength(30)]
        public string BowlerName { get; set; } // bowler_name (length: 30)

        [StringLength(255)]
        public string Address { get; set; } // address (length: 255)

        [StringLength(50)]
        public string Phone { get; set; } // phone (length: 50)

        [StringLength(255)]
        public string Email { get; set; } // email (length: 255)

        [StringLength(1)]
        [RegularExpression("[FfMm]", ErrorMessage = "Must be F or M.")]
        public string Gender { get; set; } // gender (length: 1)

        [StringLength(1)]
        [RegularExpression("[YyNn]", ErrorMessage = "Must be Y or N.")]
        public string PrivacyFlag { get; set; } // privacy_flag (length: 1)

        [StringLength(1)]
        [RegularExpression("[YyNn]", ErrorMessage = "Must be Y or N.")]
        public string ActiveFlag { get; set; } // active_flag (length: 1)

        public int TeamId { get; set; } // team_id
        public string TeamName { get; set; }
        public int Position { get; set; } // position

    }
}