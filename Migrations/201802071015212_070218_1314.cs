namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _070218_1314 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "DateOffer", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "DateOffer", c => c.DateTime(nullable: false));
        }
    }
}
