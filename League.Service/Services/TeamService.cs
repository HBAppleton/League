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
    public class TeamService : EntityService<Team>, ITeamService
    {
        IUnitOfWork _unitOfWork;
        ITeamRepository _TeamRepository;

        public TeamService(IUnitOfWork unitOfWork, ITeamRepository TeamRepository) : base(unitOfWork, TeamRepository)
        {
            _unitOfWork = unitOfWork;
            _TeamRepository = TeamRepository;
        }

        public Team GetById(long Id)
        {
            return _TeamRepository.GetById(Id);
        }

        public IEnumerable GetActive()
        {
            return _TeamRepository.GetActive();
        }
    }
}
