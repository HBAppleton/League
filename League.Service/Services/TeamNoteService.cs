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
    public class TeamNoteService : EntityService<Teamnote>, ITeamNoteService 
    {
        IUnitOfWork _unitOfWork;
        ITeamNoteRepository _teamNoteRepository;

        public TeamNoteService(IUnitOfWork unitOfWork, ITeamNoteRepository TeamNoteRepository) : base(unitOfWork, TeamNoteRepository)
        {
            _unitOfWork = unitOfWork;
            _teamNoteRepository = TeamNoteRepository;
        }

        public Teamnote GetById(long Id)
        {
            return _teamNoteRepository.GetById(Id);
        }

        public IEnumerable GetActive()
        {
            return _teamNoteRepository.GetActive();
        }

        public IEnumerable GetByTeamId(long teamId)
        {
            return _teamNoteRepository.GetByTeamId(teamId);
        }

        public IEnumerable GetByTeamSeason(long teamId, int season)
        {
            return _teamNoteRepository.GetByTeamSeason(teamId, season);
        }
    }
}
