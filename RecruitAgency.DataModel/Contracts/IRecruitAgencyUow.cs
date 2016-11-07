namespace RecruitAgency.Data
{
    /// <summary>
    /// Interface for the Code Camper "Unit of Work"
    /// </summary>
    public interface IRecruitAgencyUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        IRecruiterRepository People { get; }
        IAgenciesRepository Agencies { get; }
        IOpportunityRepository Jobs { get; }

    }
}
