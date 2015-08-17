using System.Data.Entity.Migrations;

namespace Model.Migrations
{
    public partial class ParentTasks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Parent_Id", c => c.Int());
            CreateIndex("dbo.Tasks", "Parent_Id");
            AddForeignKey("dbo.Tasks", "Parent_Id", "dbo.Tasks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Parent_Id", "dbo.Tasks");
            DropIndex("dbo.Tasks", new[] { "Parent_Id" });
            DropColumn("dbo.Tasks", "Parent_Id");
        }
    }
}
