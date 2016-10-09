namespace RecruitAgency.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version0_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("recruit.Agency", "CompanyName", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("recruit.Agency", "CompanyName", unique: true, name: "UN_Agency");
        }
        
        public override void Down()
        {
            DropIndex("recruit.Agency", "UN_Agency");
            AlterColumn("recruit.Agency", "CompanyName", c => c.String());
        }
    }
}
