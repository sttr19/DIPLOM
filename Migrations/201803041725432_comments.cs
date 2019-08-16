namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ClientFromId = c.String(),
                        ContractorToId = c.String(),
                        Text = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.AdPosts", "CommentId");
            AddForeignKey("dbo.AdPosts", "CommentId", "dbo.Comments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdPosts", "CommentId", "dbo.Comments");
            DropIndex("dbo.AdPosts", new[] { "CommentId" });
            DropTable("dbo.Comments");
        }
    }
}
