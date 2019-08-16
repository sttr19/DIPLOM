namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class booltostring_IsActual : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdPosts", "IsActual", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdPosts", "IsActual", c => c.Boolean());
        }
    }
}
