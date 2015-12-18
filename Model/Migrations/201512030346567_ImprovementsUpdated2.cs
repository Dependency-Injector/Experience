namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImprovementsUpdated2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Improvements", "AssociatedSkill_Id", c => c.Int());
            CreateIndex("dbo.Improvements", "AssociatedSkill_Id");
            AddForeignKey("dbo.Improvements", "AssociatedSkill_Id", "dbo.Skills", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Improvements", "AssociatedSkill_Id", "dbo.Skills");
            DropIndex("dbo.Improvements", new[] { "AssociatedSkill_Id" });
            DropColumn("dbo.Improvements", "AssociatedSkill_Id");
        }
    }
}
