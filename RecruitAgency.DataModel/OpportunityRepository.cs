
namespace RecruitAgency.Data
{
    using System.Data.Entity;
    using RecruitAgency.Model;
    public class OpportunityRepository : EFRepository<Opportunity>, IOpportunityRepository
    {
        public OpportunityRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
