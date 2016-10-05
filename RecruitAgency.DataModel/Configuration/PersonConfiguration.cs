using RecruitAgency.Model;
using System.Data.Entity.ModelConfiguration;

namespace RecruitAgency.Data.Configuration
{
    public class PersonConfiguration: EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("People");
            Property(g => g.FirstName).IsRequired().HasMaxLength(100);
            Property(g => g.LastName).IsRequired().HasMaxLength(100);
            
        }
    }
}
