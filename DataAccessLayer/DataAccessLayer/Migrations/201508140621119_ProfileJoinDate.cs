namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileJoinDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "JoinDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "JoinDate");
        }
    }
}
