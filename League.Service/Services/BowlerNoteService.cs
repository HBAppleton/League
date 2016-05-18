using League.Model;
using League.Repository;
using League.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class BowlerNoteService : EntityService<Bowlernote>, IBowlerNoteService
    {
        IUnitOfWork _unitOfWork;
        IBowlerNoteRepository _bowlerNoteRepository;

        public BowlerNoteService(IUnitOfWork unitOfWork, IBowlerNoteRepository BowlerNoteRepository) : base(unitOfWork, BowlerNoteRepository)
        {
            _unitOfWork = unitOfWork;
            _bowlerNoteRepository = BowlerNoteRepository;
        }

        public Bowlernote GetById(long Id)
        {
            return _bowlerNoteRepository.GetById(Id);
        }

        public IEnumerable GetActive()
        {
            return _bowlerNoteRepository.GetActive();
        }
    }
}
