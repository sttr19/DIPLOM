namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two_binds_for_comments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "IdPost", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "ContractorToId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Comments", "ContractorToId");
            CreateIndex("dbo.Comments", "IdPost");
            AddForeignKey("dbo.Comments", "IdPost", "dbo.AdPosts", "AdPostId", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "ContractorToId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "ContractorToId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "IdPost", "dbo.AdPosts");
            DropIndex("dbo.Comments", new[] { "IdPost" });
            DropIndex("dbo.Comments", new[] { "ContractorToId" });
            AlterColumn("dbo.Comments", "ContractorToId", c => c.String());
            DropColumn("dbo.Comments", "IdPost");
        }
    }
}
