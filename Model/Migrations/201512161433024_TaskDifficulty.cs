namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskDifficulty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Difficulty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Difficulty");
        }
    }
}
