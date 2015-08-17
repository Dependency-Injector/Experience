namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HistoryEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Occured = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HistoryEvents");
        }
    }
}
