namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LanguagePreference : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Preferences", "Language", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Preferences", "Language");
        }
    }
}
