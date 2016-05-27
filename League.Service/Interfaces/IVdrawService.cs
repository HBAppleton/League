using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service
{
    public interface IVdrawService : IEntityService<Vdraw>
    {
        Vdraw GetById(long Id);
        IEnumerable<Vdraw> GetBySeason(int Season);
        IEnumerable<Vdraw> GetActive();
    }
}
