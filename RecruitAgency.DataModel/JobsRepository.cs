using System.Data.Entity;
using RecruitAgency.Model;

namespace RecruitAgency.Data
{
    public class JobsRepository : EFRepository<Person>, IJobsRepository
    {
        public JobsRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
