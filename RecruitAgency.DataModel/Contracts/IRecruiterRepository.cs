namespace RecruitAgency.Data
{
    using RecruitAgency.Model;
    using System.Linq;

    public interface IRecruiterRepository:IRepository<Recruiter>
    {
        // Add any custom person stuff. 
        IQueryable<Opportunity> GetJobs();
    }
}
