namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _060218_1730 : DbMigration
    {
        public override void Up()
        {
           
            
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        OfferId = c.Int(nullable: false, identity: true),
                        IdPost = c.Int(nullable: false),
                        State = c.Boolean(nullable: false),
                        DateOffer = c.DateTime(nullable: false),
                        UserIdClient = c.String(),
                        UserIdContractor = c.String(),
                    })
                .PrimaryKey(t => t.OfferId)
                .ForeignKey("dbo.AdPosts", t => t.IdPost, cascadeDelete: true)
                .Index(t => t.IdPost);
            
       
            
         
            
        }
        
        public override void Down()
        {
         
            DropForeignKey("dbo.Offers", "IdPost", "dbo.AdPosts");
            
            DropIndex("dbo.Offers", new[] { "IdPost" });
            
           
            DropTable("dbo.Offers");
          
        }
    }
}
