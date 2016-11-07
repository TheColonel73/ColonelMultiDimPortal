using RecruitAgency.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace RecruitAgency.Data.Configuration
{
    public class PersonConfiguration: EntityTypeConfiguration<Recruiter>
    {
        string uniqueIndex = "UN_PersonName";
        public PersonConfiguration()
        {
            ToTable("People");
            Property(g => g.FirstName).IsRequired().HasMaxLength(100);
            Property(g => g.LastName).IsRequired().HasMaxLength(100);
            
        }
    }
}
