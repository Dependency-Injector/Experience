namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalHistoryEventData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryEvents", "AssociatedEntityId", c => c.Int());
            AddColumn("dbo.HistoryEvents", "AdditionalInfo", c => c.String());
            DropColumn("dbo.HistoryEvents", "TaskId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HistoryEvents", "TaskId", c => c.Int());
            DropColumn("dbo.HistoryEvents", "AdditionalInfo");
            DropColumn("dbo.HistoryEvents", "AssociatedEntityId");
        }
    }
}
