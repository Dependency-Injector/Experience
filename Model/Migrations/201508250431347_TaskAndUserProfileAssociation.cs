namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskAndUserProfileAssociation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Owner_Id", c => c.Int());
            AlterColumn("dbo.Profiles", "BirthDate", c => c.DateTime());
            CreateIndex("dbo.Tasks", "Owner_Id");
            AddForeignKey("dbo.Tasks", "Owner_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Owner_Id", "dbo.Profiles");
            DropIndex("dbo.Tasks", new[] { "Owner_Id" });
            AlterColumn("dbo.Profiles", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tasks", "Owner_Id");
        }
    }
}
