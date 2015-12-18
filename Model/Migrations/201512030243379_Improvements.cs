namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Improvements : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Improvements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Origin = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        AssociatedEntityId = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Improvements", "Owner_Id", "dbo.Profiles");
            DropIndex("dbo.Improvements", new[] { "Owner_Id" });
            DropTable("dbo.Improvements");
        }
    }
}
