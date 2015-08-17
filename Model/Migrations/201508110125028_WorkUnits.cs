using System.Data.Entity.Migrations;

namespace Model.Migrations
{
    public partial class WorkUnits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        Duration = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Task_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkUnits", "Task_Id", "dbo.Tasks");
            DropIndex("dbo.WorkUnits", new[] { "Task_Id" });
            DropTable("dbo.WorkUnits");
        }
    }
}
