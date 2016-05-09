using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public interface IBowlerNoteRepository : IGenericRepository<Bowlernote>
    {
        Bowlernote GetById(long Id);

        IEnumerable<Bowlernote> GetByBowlerId(long BowlerId);
        IEnumerable<Bowlernote> GetByBowlerSeason(long BowlerId, int Season);
    }
}
