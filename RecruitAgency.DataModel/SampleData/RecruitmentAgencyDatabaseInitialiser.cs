﻿using System.Data.Entity;

namespace RecruitAgency.Data.SampleData
{
    public class RecruitmentAgencyDatabaseInitialiser:
        DropCreateDatabaseAlways<RecruitAgencyDbContext>
    {
        public RecruitmentAgencyDatabaseInitialiser()
        {
            //AutomaticMigrationsEnabled = false;
        }
        
    }
}
