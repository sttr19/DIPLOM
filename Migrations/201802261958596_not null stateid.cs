namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notnullstateid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "StateId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "StateId", c => c.Int());
        }
    }
}
