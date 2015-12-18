namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImprovementsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Improvements", "Occured", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Improvements", "Type", c => c.String());
            AlterColumn("dbo.Improvements", "Origin", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Improvements", "Origin", c => c.Int(nullable: false));
            AlterColumn("dbo.Improvements", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Improvements", "Occured");
        }
    }
}
