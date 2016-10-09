using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RecruitAgency.Model;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitAgency.Data.Configuration
{
    public class AgencyConfiguration: EntityTypeConfiguration<Agency>
    {
        public AgencyConfiguration()
        {

            Property(g => g.CompanyName).IsRequired().HasMaxLength(100)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(
                    new IndexAttribute("UN_Agency")
                    {
                        IsUnique = true,
                        Order = 1
                    }));
             
        }
    }
}
