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
    public class AveragesService : EntityService<Average>, IAveragesService
    {
        IUnitOfWork _unitOfWork;
        IAveragesRepository _averagesRepository;

        public AveragesService(IUnitOfWork unitOfWork, 
                               IAveragesRepository averagesRepository) : base(unitOfWork, averagesRepository)
        {
            _unitOfWork = unitOfWork;
            _averagesRepository = averagesRepository;
        }

        public Average GetById(long Id)
        {
            return _averagesRepository.GetById(Id);
        }

        public void ResetAverages(long weekId)
        {
            // Call database function to re-populate the Averages table for the desired week
            _averagesRepository.ResetAverages(weekId);
        }

    }
}
