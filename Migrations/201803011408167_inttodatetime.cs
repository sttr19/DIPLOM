namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdPosts", "TimeOver", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdPosts", "TimeOver", c => c.Int());
        }
    }
}
