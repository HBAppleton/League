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
    }
}
