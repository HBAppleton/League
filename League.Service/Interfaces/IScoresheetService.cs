using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IScoresheetService : IEntityService<Scoresheet>
    {
        Scoresheet GetById(long Id);
    }
}


