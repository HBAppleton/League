using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace League.ViewModels
{
    public class VweekViewModel
    {
        public System.DateTime? WeekDate { get; set; } // week_date
        public int Season { get; set; } // season
        public int WeekNumber { get; set; } // week_number
        public int Round { get; set; } // round
        public int? RoundWeek { get; set; } // round_week
        public int Id { get; set; } // id
    }
}
