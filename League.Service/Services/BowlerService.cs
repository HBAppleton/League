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
    public class BowlerService : EntityService<Bowler>, IBowlerService 
    {
        IUnitOfWork _unitOfWork;
        IBowlerRepository _bowlerRepository;

        public BowlerService(IUnitOfWork unitOfWork, IBowlerRepository BowlerRepository) : base(unitOfWork, BowlerRepository)
        {
            _unitOfWork = unitOfWork;
            _bowlerRepository = BowlerRepository;
        }

        public Bowler GetById(long Id)
        {
            return _bowlerRepository.GetById(Id);
        }

        public IEnumerable GetActive()
        {
            return _bowlerRepository.GetActive();
        }
    }
}
