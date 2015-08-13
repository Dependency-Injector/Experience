namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileHistory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "History", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "History");
        }
    }
}
