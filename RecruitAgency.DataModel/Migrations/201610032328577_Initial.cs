namespace RecruitAgency.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "recruit.Agency",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CompanyName = c.String(),
                        Address = c.String(),
                        Url = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "recruit.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        EmailAddress = c.String(),
                        TelephoneNumber = c.String(),
                        PreferredContactType = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        Agency_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("recruit.Agency", t => t.Agency_ID)
                .Index(t => t.Agency_ID);
            
            CreateTable(
                "recruit.JobOpportunity",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Notes = c.String(),
                        Person_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("recruit.People", t => t.Person_ID)
                .Index(t => t.Person_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("recruit.JobOpportunity", "Person_ID", "recruit.People");
            DropForeignKey("recruit.People", "Agency_ID", "recruit.Agency");
            DropIndex("recruit.JobOpportunity", new[] { "Person_ID" });
            DropIndex("recruit.People", new[] { "Agency_ID" });
            DropTable("recruit.JobOpportunity");
            DropTable("recruit.People");
            DropTable("recruit.Agency");
        }
    }
}
