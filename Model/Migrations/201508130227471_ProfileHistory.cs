using System.Data.Entity.Migrations;

namespace Model.Migrations
{
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
