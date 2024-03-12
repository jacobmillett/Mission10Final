
using Microsoft.EntityFrameworkCore;

namespace Mission10_API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {

        private BowlerContext _Bowlercontext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _Bowlercontext = temp;
        }

        public IEnumerable<Bowlers> Bowlers
        {
            get
            {
                // Include the TeamName navigation property to fetch team names
                return _Bowlercontext.Bowlers.Include(b => b.TeamName).ToList();
            }
        }
    }
}
