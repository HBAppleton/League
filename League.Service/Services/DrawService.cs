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
    public class DrawService : EntityService<Draw>, IDrawService
    {
        IUnitOfWork _unitOfWork;
        IDrawRepository _drawRepository;

        public DrawService(IUnitOfWork unitOfWork, IDrawRepository DrawRepository) : base(unitOfWork, DrawRepository)
        {
            _unitOfWork = unitOfWork;
            _drawRepository = DrawRepository;
        }

        public Draw GetById(long Id)
        {
            return _drawRepository.GetById(Id);
        }
    }
}
