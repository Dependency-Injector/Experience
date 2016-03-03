namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotesAndNotesLists : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AdditionalInfo = c.String(),
                        Checked = c.Boolean(),
                        NotesList_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NotesLists", t => t.NotesList_Id)
                .Index(t => t.NotesList_Id);
            
            CreateTable(
                "dbo.NotesLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotesLists", "Owner_Id", "dbo.Profiles");
            DropForeignKey("dbo.Notes", "NotesList_Id", "dbo.NotesLists");
            DropIndex("dbo.NotesLists", new[] { "Owner_Id" });
            DropIndex("dbo.Notes", new[] { "NotesList_Id" });
            DropTable("dbo.NotesLists");
            DropTable("dbo.Notes");
        }
    }
}
