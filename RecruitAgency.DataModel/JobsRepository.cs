
namespace RecruitAgency.Data
{
    using System.Data.Entity;
    using RecruitAgency.Model;
    public class JobsRepository : EFRepository<JobOpportunity>, IJobsRepository
    {
        public JobsRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
