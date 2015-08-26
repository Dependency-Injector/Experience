namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerAndOtherTablesAssociation : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Skills", name: "Profile_Id", newName: "Owner_Id");
            RenameIndex(table: "dbo.Skills", name: "IX_Profile_Id", newName: "IX_Owner_Id");
            AddColumn("dbo.HistoryEvents", "Owner_Id", c => c.Int());
            AddColumn("dbo.Preferences", "Owner_Id", c => c.Int());
            CreateIndex("dbo.HistoryEvents", "Owner_Id");
            CreateIndex("dbo.Preferences", "Owner_Id");
            AddForeignKey("dbo.HistoryEvents", "Owner_Id", "dbo.Profiles", "Id");
            AddForeignKey("dbo.Preferences", "Owner_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Preferences", "Owner_Id", "dbo.Profiles");
            DropForeignKey("dbo.HistoryEvents", "Owner_Id", "dbo.Profiles");
            DropIndex("dbo.Preferences", new[] { "Owner_Id" });
            DropIndex("dbo.HistoryEvents", new[] { "Owner_Id" });
            DropColumn("dbo.Preferences", "Owner_Id");
            DropColumn("dbo.HistoryEvents", "Owner_Id");
            RenameIndex(table: "dbo.Skills", name: "IX_Owner_Id", newName: "IX_Profile_Id");
            RenameColumn(table: "dbo.Skills", name: "Owner_Id", newName: "Profile_Id");
        }
    }
}
