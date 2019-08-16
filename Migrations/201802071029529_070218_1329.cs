namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _070218_1329 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "State", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "State", c => c.Boolean(nullable: false));
        }
    }
}
