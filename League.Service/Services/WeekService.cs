using League.Model;
using League.Repository;
using League.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class WeekService : EntityService<Week>, IWeekService
    {
        IUnitOfWork _unitOfWork;
        IWeekRepository _weekRepository;

        public WeekService(IUnitOfWork unitOfWork, IWeekRepository WeekRepository) : base(unitOfWork, WeekRepository)
        {
            _unitOfWork = unitOfWork;
            _weekRepository = WeekRepository;
        }

        public Week GetById(long Id)
        {
            return _weekRepository.GetById(Id);
        }

        public IEnumerable GetBySeason(int Season)
        {
            return _weekRepository.GetBySeason(Season);
        }

        public IEnumerable GetActive()
        {
            return _weekRepository.GetActive();
        }
    }
}
