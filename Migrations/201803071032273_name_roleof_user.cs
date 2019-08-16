namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name_roleof_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdPosts", "NameOfUser", c => c.String());
            AddColumn("dbo.AdPosts", "RoleOfUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdPosts", "RoleOfUser");
            DropColumn("dbo.AdPosts", "NameOfUser");
        }
    }
}
