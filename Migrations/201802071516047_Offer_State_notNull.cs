namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Offer_State_notNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "State", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "State", c => c.Boolean());
        }
    }
}
