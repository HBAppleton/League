using League.Model;
using League.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IAveragesService : IEntityService<Average>
    {
        Average GetById(long id);

        void ResetAverages(long weekId);
    }
}
