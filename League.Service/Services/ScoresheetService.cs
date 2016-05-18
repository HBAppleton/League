using League.Model;
using League.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public class ScoresheetService : EntityService<Scoresheet>, IScoresheetService
    {
        IUnitOfWork _unitOfWork;
        IScoreSheetRepository _scoresheetRepository;

        public ScoresheetService(IUnitOfWork unitOfWork, IScoreSheetRepository ScoresheetRepository) : base(unitOfWork, ScoresheetRepository)
        {
            _unitOfWork = unitOfWork;
            _scoresheetRepository = ScoresheetRepository;
        }

        public Scoresheet GetById(long Id)
        {
            return _scoresheetRepository.GetById(Id);
        }
    }
}
