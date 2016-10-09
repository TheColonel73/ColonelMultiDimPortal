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
        IPersonsRepository People { get; }
        IAgenciesRepository Agencies { get; }
        IJobsRepository Jobs { get; }

    }
}
