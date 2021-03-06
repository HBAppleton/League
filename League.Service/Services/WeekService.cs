﻿using League.Model;
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

        public void SetupSeason(int year)
        {
            if (!DoesSeasonExist(year))
            {
                // Get Season Start
                DateTime ldt_weekdate = DateHelper.GetLeagueFirstNight(year);

                // Get Fieldays date as week to be skipped
                DateTime ldt_fieldays = DateHelper.GetFieldaysStartDate(year);

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

                _weekRepository.Save();
            }

            return;
        }

        public Boolean DoesSeasonExist(int year)
        {
            Boolean lb_exists = false;

            IEnumerable<Week> week = GetBySeason(year);
            if (week.Count() > 0)
            {
                lb_exists = true;
            }

            return lb_exists;
        }
    }
}
