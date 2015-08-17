using System.Data.Entity.Migrations;

namespace Model.Migrations
{
    public partial class Skills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Experience = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Profile_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Skills", new[] { "Profile_Id" });
            DropTable("dbo.Skills");
        }
    }
}
