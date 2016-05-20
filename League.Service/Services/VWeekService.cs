﻿using League.Model;
using League.Repository;
using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public class VWeekService : EntityService<Vweek>, IVWeekService
    {
        IUnitOfWork _unitOfWork;
        IVWeekRepository _vweekRepository;

        public VWeekService(IUnitOfWork unitOfWork, IVWeekRepository vweekRepository) : base(unitOfWork, vweekRepository)
        {
            _unitOfWork = unitOfWork;
            _vweekRepository = vweekRepository;
        }

        public Vweek GetById(long id)
        {
            return _vweekRepository.GetById(id);
        }

        public IEnumerable<Vweek> GetBySeason(int season)
        {
            return _vweekRepository.GetBySeason(season);
        }

        public IEnumerable<Vweek> GetActive()
        {
            return _vweekRepository.GetActive();
        }
    }
}