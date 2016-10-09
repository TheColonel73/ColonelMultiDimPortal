using System;
using System.Data.Entity;
using System.Linq;
using RecruitAgency.Model;

namespace RecruitAgency.Data
{
    public class PersonsRepository : EFRepository<Person>,IPersonsRepository
    {
        public PersonsRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<JobOpportunity> GetJobs()
        {
            throw new NotImplementedException();
        }
    }
}
