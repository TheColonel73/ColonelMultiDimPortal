using System;
using Xunit;

using RecruitAgency.Model;
using RecruitAgency.Data;

namespace UnitTestEntityProject
{
    
    public class EntityTest
    {
        RecruitAgencyUow uow;
        public EntityTest()
        {
            IRepositoryProvider provider = new RepositoryProvider(new RepositoryFactories());
            uow = new RecruitAgencyUow(provider);
        }

        [Fact]
        public void TestMethod1()
        {
            Agency agency = uow.Agencies.Add(new Agency { CompanyName = "Test DB" });
            agency.Persons.Add(new Recruiter { FirstName = "Gary", LastName = "Hodgson" });

            Assert.IsType(typeof(Agency),agency);
        }
    }
}
