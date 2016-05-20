using League.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace League.Repository
{
    public class BowlerRepository : GenericRepository<Bowler>, IBowlerRepository
    {
        public BowlerRepository(MyDbContext context) : base(context)
        {

        }

        public Bowler GetById(long id)
        {
            return _dbset.Where(b => b.Id == id).Include(t => t.TeamId).FirstOrDefault();
        }

        public override IEnumerable<Bowler> GetAll()
        {
            return _entities.Set<Bowler>().Include(t => t.TeamId).OrderByDescending(b=>b.ActiveFlag).ThenBy(b=>b.BowlerName).AsEnumerable();
        }

        public IEnumerable<Bowler> GetActive()
        {
            return _entities.Set<Bowler>().Include(t => t.TeamId).Where(b => b.ActiveFlag == "Y").OrderBy(b=>b.BowlerName).AsEnumerable();
        }

        public IEnumerable<Bowler> GetByTeamId (long Id)
        {
            return _entities.Set<Bowler>().Include(t => t.TeamId).Where(b => b.TeamId == Id).OrderBy(b=>b.Position).AsEnumerable();
        }
    }
}
