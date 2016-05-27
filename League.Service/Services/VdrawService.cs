using League.Model;
using League.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public class VdrawService : EntityService<Vdraw>, IVdrawService
    {
        IUnitOfWork _unitOfWork;
        IVdrawRepository _vdrawRepository;

        public VdrawService(IUnitOfWork unitOfWork, IVdrawRepository vdrawRepository) : base(unitOfWork, vdrawRepository)
        {
            _unitOfWork = unitOfWork;
            _vdrawRepository = vdrawRepository;
        }

        public Vdraw GetById(long id)
        {
            return _vdrawRepository.GetById(id);
        }

        public IEnumerable<Vdraw> GetBySeason(int season)
        {
            return _vdrawRepository.GetBySeason(season);
        }

        public IEnumerable<Vdraw> GetActive()
        {
            return _vdrawRepository.GetActive();
        }
    }
}
