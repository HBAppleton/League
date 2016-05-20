using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class VweekViewModel
    {
        [Display(Name = "Date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime? WeekDate { get; set; } // week_date

        [Display(Name = "Season")]
        [StringLength(4)]
        [Required]
        public int Season { get; set; } // season


        [Display(Name = "Week Number")]
        [StringLength(2)]
        [Required]
        [Range(1, 39)]
        public int WeekNumber { get; set; } // week_number


        public int Round { get; set; } // round

        [Display(Name = "Round Week")]
        public int? RoundWeek { get; set; } // round_week

        public int Id { get; set; } // id
    }
}
