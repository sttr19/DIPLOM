namespace DP_60321_TROSHKO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stateoffers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StateOffers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Offers", "StateId");
            AddForeignKey("dbo.Offers", "StateId", "dbo.StateOffers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "StateId", "dbo.StateOffers");
            DropIndex("dbo.Offers", new[] { "StateId" });
            DropTable("dbo.StateOffers");
        }
    }
}
