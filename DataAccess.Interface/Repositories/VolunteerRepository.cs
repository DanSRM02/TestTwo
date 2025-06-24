using DataAccess.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class VolunteerRepository : Repository<Volunteer>, IVolunteerRepository
    {
        public VolunteerRepository(TestTwoContext context) : base(context)
        {            
        }
    }
}
