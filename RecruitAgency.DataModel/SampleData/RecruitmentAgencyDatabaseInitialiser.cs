using RecruitAgency.Model;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;

namespace RecruitAgency.Data.SampleData
{
    public class RecruitmentAgencyDatabaseInitialiser:
        DropCreateDatabaseAlways<RecruitAgencyDbContext>
    {
        
        public RecruitmentAgencyDatabaseInitialiser()
        {
            //AutomaticMigrationsEnabled = true;
        }
        

        protected override void Seed(RecruitAgencyDbContext context)
        {
            throw new System.Exception("I am called!");
            //IList<Agency> agencyList = new List<Agency>();

            //agencyList.Add(new Agency { CompanyName = "Default" });

            //Recruiter recruiter = new Recruiter{ Agency = agencyList[0], FirstName = "Gary",
            //    LastName = "Hodgson" };


            
            //base.Seed(context);
        }
    }
}
