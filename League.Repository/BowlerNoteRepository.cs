using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League.Repository
{
    public class BowlerNoteRepository : GenericRepository<Bowlernote>, IBowlerNoteRepository
    {
        public BowlerNoteRepository(MyDbContext context) : base(context)
        {

        }

        public override IEnumerable<Bowlernote> GetAll()
        {
            return _entities.Set<Bowlernote>().AsEnumerable();
        }

        public Bowlernote GetById(long Id)
        {
            return FindBy(n => n.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Bowlernote> GetByBowlerId(long BowlerId)
        {
            return _entities.Set<Bowlernote>().Where(n => n.BowlerId == BowlerId).AsEnumerable();
        }

        public IEnumerable<Bowlernote> GetByBowlerSeason(long BowlerId,int Season)
        {
            return _entities.Set<Bowlernote>().Where(n => n.BowlerId == BowlerId).Where(n => n.Season == Season).AsEnumerable();
        }
    }
}
