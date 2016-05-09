using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IDrawRepository : IGenericRepository<Draw>
    {
        Draw GetById(long id);

        IEnumerable<Draw> GetByWeekId(long id);
    }
}
