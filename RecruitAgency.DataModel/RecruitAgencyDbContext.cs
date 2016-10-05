namespace RecruitAgency.Data
{
    using System.Data.Entity;
    using RecruitAgency.Model;
    using RecruitAgency.Data.SampleData;
    using Configuration;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class RecruitAgencyDbContext : DbContext
    {
        static RecruitAgencyDbContext()
        {
            Database.SetInitializer(new RecruitmentAgencyDatabaseInitialiser());
        }
        public RecruitAgencyDbContext()
            : base(nameOrConnectionString: "recruitConnectionstring") 
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Agency> Agents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("recruit");
            modelBuilder.Types().Configure(c => c.Ignore("IsDirty"));

            modelBuilder.Configurations.Add(new PersonConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

}