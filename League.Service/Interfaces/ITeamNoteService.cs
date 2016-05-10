using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface ITeamNoteService : IEntityService<Teamnote>
    {
        Teamnote GetById(long Id);
    }
}
