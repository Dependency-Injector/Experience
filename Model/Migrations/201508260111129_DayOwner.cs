namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DayOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Days", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Days", "Owner_Id");
            AddForeignKey("dbo.Days", "Owner_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Days", "Owner_Id", "dbo.Profiles");
            DropIndex("dbo.Days", new[] { "Owner_Id" });
            DropColumn("dbo.Days", "Owner_Id");
        }
    }
}
