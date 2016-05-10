using League.Model;
using League.Repository;
using League.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class VDrawService : EntityService<Vdraw>, IVDrawService
    {
        IUnitOfWork _unitOfWork;
        IVDrawRepository _vDrawRepository;

        public VDrawService(IUnitOfWork unitOfWork, IVDrawRepository VDrawRepository) : base(unitOfWork, VDrawRepository)
        {
            _unitOfWork = unitOfWork;
            _vDrawRepository = VDrawRepository;
        }

        public Vdraw GetById(long Id)
        {
            return _vDrawRepository.GetById(Id);
        }
/*
        public Vdraw GetBySeason(int Season)
        {
            return _vDrawRepository.GetBySeason(Season);
        }

        public Vdraw GetByWeekId(long WeekId)
        {
            return _vDrawRepository.GetByWeekId(WeekId);
        }

        public Vdraw GetByTeamId(long TeamId)
        {
            return _vDrawRepository.GetByTeamId(TeamId);
        }

        public Vdraw GetByBowlerId(long BowlerId)
        {
            return _vDrawRepository.GetByBowlerId(BowlerId);
        }

        public Vdraw GetByScoresheetId(long ScoresheetId)
        {
            return _vDrawRepository.GetByScoresheetId(ScoresheetId);
        }
*/
    }
}
