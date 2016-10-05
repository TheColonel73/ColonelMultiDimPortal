using System.Data.Entity;

namespace RecruitAgency.Data.SampleData
{
    public class RecruitmentAgencyDatabaseInitialiser:
        DropCreateDatabaseIfModelChanges<RecruitAgencyDbContext>
    {
        public RecruitmentAgencyDatabaseInitialiser()
        {
            //AutomaticMigrationsEnabled = false;
        }
        
    }
}
