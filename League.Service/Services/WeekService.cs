using League.Model;
using League.Repository;
using League.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public class WeekService : EntityService<Week>, IWeekService
    {
        IUnitOfWork _unitOfWork;
        IWeekRepository _weekRepository;

        public WeekService(IUnitOfWork unitOfWork, IWeekRepository weekRepository) : base(unitOfWork, weekRepository)
        {
            _unitOfWork = unitOfWork;
            _weekRepository = weekRepository;
        }

        public Week GetById(long id)
        {
            return _weekRepository.GetById(id);
        }

        public IEnumerable<Week> GetBySeason(int season)
        {
            return _weekRepository.GetBySeason(season);
        }

        public IEnumerable<Week> GetActive()
        {
            return _weekRepository.GetActive();
        }

        public IEnumerable<Week> SetupSeason(int year)
        {
            DayOfWeek li_dow = DayOfWeek.Wednesday;

            // Get Season Start
            int li_month = 2; // February
            int li_x = 4;     // 4th week            
            DateTime ldt_weekdate = DateHelper.XthDayOfWeekInMonth(year, li_month, li_dow, li_x);

            // Get Fieldays date as week to be skipped
            li_month = 6; // June
            li_x = 2;     // 2nd week            
            DateTime ldt_fieldays = DateHelper.XthDayOfWeekInMonth(year, li_month, li_dow, li_x);

            // create an entry for 39 weeks (4x9wk Rounds, 3wkFinals)
            for (int li_weekNumber = 1; li_weekNumber <= 39; li_weekNumber++)
            {
                // insert new record 
                Week week = new Week();
                week.Season = year;
                week.WeekDate = ldt_weekdate;
                week.WeekNumber = li_weekNumber;

                _weekRepository.Add(week);

                // prepare for next iteration
                ldt_weekdate = ldt_weekdate.AddDays(7);
                if (ldt_weekdate == ldt_fieldays)
                {
                    // ignore Fieldays - no bowling 
                    ldt_weekdate = ldt_weekdate.AddDays(7);
                }
            }

            return GetBySeason(year);
        }
    }
}
