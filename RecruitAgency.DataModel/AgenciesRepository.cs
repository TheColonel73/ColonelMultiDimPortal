using System.Data.Entity;
using RecruitAgency.Model;

namespace RecruitAgency.Data
{
    public class AgenciesRepository : EFRepository<Agency>, IAgenciesRepository
    {
        public AgenciesRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
