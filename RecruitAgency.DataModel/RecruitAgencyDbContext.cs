namespace RecruitAgency.Data
{
    using System.Data.Entity;
    using RecruitAgency.Model;
    using RecruitAgency.Data.SampleData;
    using Configuration;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System;
    using System.Linq;

    public class RecruitAgencyDbContext : DbContext
    {
        
        static RecruitAgencyDbContext()
        {
            //Database.SetInitializer(null); // new RecruitmentAgencyDatabaseInitialiser());
        }
        
        public RecruitAgencyDbContext()
            : base(nameOrConnectionString: "recruitConnectionstring") 
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Agency> Agents { get; set; }

        public DbSet<JobOpportunity> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("recruit");
            modelBuilder.Types().Configure(c => c.Ignore("IsDirty"));

            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new AgencyConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModifyHistory && (e.State == EntityState.Added ||
                    e.State == EntityState.Modified))
                .Select(e => e.Entity as IModifyHistory)
                )
                {
                    history.DateModified = DateTime.Now;
                    if (history.DateCreated == DateTime.MinValue)
                    {
                        history.DateCreated = DateTime.Now;
                    }
                }
            int result = base.SaveChanges();
            foreach (var history in this.ChangeTracker.Entries()
                                          .Where(e => e.Entity is IModifyHistory)
                                          .Select(e => e.Entity as IModifyHistory)
              )
            {
                history.IsDirty = false;
            }
            return result;
        }
    }

}