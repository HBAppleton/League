using League.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IAveragesRepository : IGenericRepository<Average>
    {
        Average GetById(long id);

        void ResetAverages(long weekId);
    }
}
