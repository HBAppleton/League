using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using League.Model;

namespace League.ViewModels
{
    public class BowlerViewModel
    {
        public int Id { get; set; } // id (Primary key)

        public string BowlerName { get; set; } // bowler_name (length: 30)

        public string Address { get; set; } // address (length: 255)
        public string Phone { get; set; } // phone (length: 50)
        public string Email { get; set; } // email (length: 255)
        public string Gender { get; set; } // gender (length: 1)


        public string PrivacyFlag { get; set; } // privacy_flag (length: 1)
        public string ActiveFlag { get; set; } // active_flag (length: 1)

        public int TeamId { get; set; } // team_id
        public string TeamName { get; set; }
        public int Position { get; set; } // position

    }
}