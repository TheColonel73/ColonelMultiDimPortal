using System.Data.Entity;

using RecruitAgency.Model;

namespace RecruitAgency.Data
{
    public class PersonsRepository : EFRepository<Person>,IPersonsRepository
    {
        public PersonsRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
