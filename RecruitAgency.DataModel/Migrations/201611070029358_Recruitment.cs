namespace RecruitAgency.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recruitment : DbMigration
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
                        CompanyName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(),
                        Url = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.CompanyName, unique: true, name: "UN_Agency");
            
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
                "recruit.Opportunity",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Notes = c.String(),
                        Recruiter_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("recruit.People", t => t.Recruiter_ID)
                .Index(t => t.Recruiter_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("recruit.Opportunity", "Recruiter_ID", "recruit.People");
            DropForeignKey("recruit.People", "Agency_ID", "recruit.Agency");
            DropIndex("recruit.Opportunity", new[] { "Recruiter_ID" });
            DropIndex("recruit.People", new[] { "Agency_ID" });
            DropIndex("recruit.Agency", "UN_Agency");
            DropTable("recruit.Opportunity");
            DropTable("recruit.People");
            DropTable("recruit.Agency");
        }
    }
}
