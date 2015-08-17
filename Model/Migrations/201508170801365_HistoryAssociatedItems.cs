namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HistoryAssociatedItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryEvents", "Description", c => c.String());
            AddColumn("dbo.HistoryEvents", "AssociatedEntityId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HistoryEvents", "AssociatedEntityId");
            DropColumn("dbo.HistoryEvents", "Description");
        }
    }
}
