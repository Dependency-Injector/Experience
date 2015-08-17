using System.Data.Entity.Migrations;

namespace Model.Migrations
{
    public partial class SkillsAndTaskAssociation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "SkillToTrain_Id", c => c.Int());
            CreateIndex("dbo.Tasks", "SkillToTrain_Id");
            AddForeignKey("dbo.Tasks", "SkillToTrain_Id", "dbo.Skills", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "SkillToTrain_Id", "dbo.Skills");
            DropIndex("dbo.Tasks", new[] { "SkillToTrain_Id" });
            DropColumn("dbo.Tasks", "SkillToTrain_Id");
        }
    }
}
