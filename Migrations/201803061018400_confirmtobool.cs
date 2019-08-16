namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class confirmtobool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdPosts", "Confirm", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdPosts", "Confirm", c => c.String());
        }
    }
}
