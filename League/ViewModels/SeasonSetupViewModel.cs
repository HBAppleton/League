using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace League.ViewModels
{
    public class SeasonSetupViewModel
    {
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Season")]
        [Required]
        public int Season { get; set; } 

        [Display(Name = "First Night")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime FirstNight { get; set; } 

        [Display(Name = "Fieldays")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime Fieldays { get; set; } 

    }
}