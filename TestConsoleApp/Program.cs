using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RecruitAgency.Data;
using RecruitAgency.Model;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RecruitAgency.Data.RepositoryProvider provider = new RecruitAgency.Data.RepositoryProvider(new RecruitAgency.Data.RepositoryFactories());

            RecruitAgency.Data.RecruitAgencyUow uow = new RecruitAgency.Data.RecruitAgencyUow(provider);

            Agency agency = new Agency { CompanyName = "Gary's Recruitment Agency." };

            //agency.Url = "www.test.co.uk";

            //new Agency { CompanyName = "Gary's Recruitment Agency." };

            //agency.Address = "1 High Street";
            //agency.Telephone = "123456789";
            
            uow.Agencies.Add(agency);

            uow.Commit();
        }
    }
}
