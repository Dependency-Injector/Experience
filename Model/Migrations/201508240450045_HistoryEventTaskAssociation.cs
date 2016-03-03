namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HistoryEventTaskAssociation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryEvents", "TaskId", c => c.Int());
            DropColumn("dbo.HistoryEvents", "AssociatedEntityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HistoryEvents", "AssociatedEntityId", c => c.Int(nullable: false));
            DropColumn("dbo.HistoryEvents", "TaskId");
        }
    }
}
