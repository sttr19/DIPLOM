namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdContractor_FK : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "UserIdContractor", c => c.String(maxLength: 128));
            CreateIndex("dbo.Offers", "UserIdContractor");
            AddForeignKey("dbo.Offers", "UserIdContractor", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "UserIdContractor", "dbo.AspNetUsers");
            DropIndex("dbo.Offers", new[] { "UserIdContractor" });
            AlterColumn("dbo.Offers", "UserIdContractor", c => c.String());
        }
    }
}
