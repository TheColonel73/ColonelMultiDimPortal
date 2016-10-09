namespace RecruitAgency.Data
{
    using RecruitAgency.Model;
    using System.Linq;

    public interface IPersonsRepository:IRepository<Person>
    {
        // Add any custom person stuff. 
        IQueryable<JobOpportunity> GetJobs();
    }
}
