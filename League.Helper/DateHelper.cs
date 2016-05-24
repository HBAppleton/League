using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Helper
{
    public class DateHelper
    {
        public static DateTime FirstDayOfWeekInMonth(int year, int month, DayOfWeek day)
        {
            DateTime ldt_firstday = new DateTime(year, month, 1);
            int offset = -(ldt_firstday.DayOfWeek - day);

            if (offset < 0)
                offset += 7;

            ldt_firstday = ldt_firstday.AddDays(offset);

            return ldt_firstday;
        }

        public static DateTime XthDayOfWeekInMonth(int year, int month, DayOfWeek day, int x)
        {
            DateTime ldt_xDay = DateTime.MinValue;

            if (x > 0)
            {
                ldt_xDay = FirstDayOfWeekInMonth(year, month, day);

                if (x > 1)
                {
                    ldt_xDay = ldt_xDay.AddDays((x - 1) * 7);
                }

                ldt_xDay = ldt_xDay.Year == year && ldt_xDay.Month == month ? ldt_xDay : DateTime.MinValue;
            }

            return ldt_xDay;
        }

        public static DateTime GetFieldaysStartDate(int year)
        {
            DayOfWeek li_dow = DayOfWeek.Wednesday;

            int li_month = 6; // June
            int li_x = 2;     // 2nd week    
            
            if (year == 2016)
            {
                li_x = 3;  
            }

            return DateHelper.XthDayOfWeekInMonth(year, li_month, li_dow, li_x);
        }

        public static DateTime GetLeagueFirstNight(int year)
        {
            DayOfWeek li_dow = DayOfWeek.Wednesday;

            int li_month = 2; // February
            int li_x = 4;     // 4th week    

            return DateHelper.XthDayOfWeekInMonth(year, li_month, li_dow, li_x);
        }
    }
}
