using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RecruitAgency.Model;
using RecruitAgency.Data;

namespace UnitTestEntityProject
{
    [TestClass]
    public class EntityTest
    {
        RecruitAgencyUow uow;
        public EntityTest()
        {
            IRepositoryProvider provider = new RepositoryProvider(new RepositoryFactories());
            uow = new RecruitAgencyUow(provider);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Agency agency = uow.Agencies.Add(new Agency { CompanyName = "Test DB" });
            agency.Persons.Add(new Person { FirstName = "Gary", LastName = "Hodgson" });

            Assert.IsInstanceOfType(agency, typeof(Agency));
        }
    }
}
