namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delstateid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Offers", "StateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offers", "StateId", c => c.Int(nullable: false));
        }
    }
}
