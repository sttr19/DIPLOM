namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usernameclient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "UserNameClient", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "UserNameClient");
        }
    }
}
