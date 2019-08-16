namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stateid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "StateId", c => c.Int(nullable: false));
            DropColumn("dbo.Offers", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offers", "State", c => c.Boolean(nullable: false));
            DropColumn("dbo.Offers", "StateId");
        }
    }
}
