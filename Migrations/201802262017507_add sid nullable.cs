namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsidnullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "StateId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "StateId");
        }
    }
}
