using League.Model;
using League.Repository;
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
    }
}
