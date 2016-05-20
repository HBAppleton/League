using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class WeekViewModel
    {
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime WeekDate { get; set; } // week_date

        [Display(Name = "Week Number")]
        [StringLength(2)]
        [Required]
        [Range(1, 39)]
        public int WeekNumber { get; set; } // week_number

        [Display(Name = "Season")]
        [Required]
        public int Season { get; set; } // season
    }
}