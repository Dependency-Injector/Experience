namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillHoursTrained : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "ExperienceWhenNextLevel", c => c.Int(nullable: false));
            AddColumn("dbo.Skills", "HoursTrained", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "HoursTrained");
            DropColumn("dbo.Skills", "ExperienceWhenNextLevel");
        }
    }
}
