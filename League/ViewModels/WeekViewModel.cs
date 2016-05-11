using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class WeekViewModel
    {
        public int Id { get; set; } // id (Primary key)
        public System.DateTime WeekDate { get; set; } // week_date
        public int WeekNumber { get; set; } // week_number
        public int Season { get; set; } // season
    }
}