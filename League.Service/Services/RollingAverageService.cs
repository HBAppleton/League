using League.Model;
using League.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public class RollingAverageService : EntityService<VRollingAverage>, IRollingAverageService
    {
        IUnitOfWork _unitOfWork;
        IRollingAverageRepository _rollingAverageRepository;

        public RollingAverageService(IUnitOfWork unitOfWork, IRollingAverageRepository rollingAverageRepository) : base(unitOfWork, rollingAverageRepository)
        {
            _unitOfWork = unitOfWork;
            _rollingAverageRepository = rollingAverageRepository;
        }

        public VRollingAverage GetById(long Id)
        {
            return _rollingAverageRepository.GetById(Id);
        }

    }
}
