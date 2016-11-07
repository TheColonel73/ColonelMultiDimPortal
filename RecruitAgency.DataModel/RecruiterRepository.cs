using System;
using System.Data.Entity;
using System.Linq;
using RecruitAgency.Model;

namespace RecruitAgency.Data
{
    public class RecruiterRepository : EFRepository<Recruiter>,IRecruiterRepository
    {
        public RecruiterRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Opportunity> GetJobs()
        {
            throw new NotImplementedException();
        }
    }
}
