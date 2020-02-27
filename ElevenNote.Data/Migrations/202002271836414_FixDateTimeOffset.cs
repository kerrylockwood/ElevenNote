namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDateTimeOffset : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "ModifiedUtc", c => c.DateTime());
            AlterColumn("dbo.Note", "CreatedUtc", c => c.DateTime(nullable: false));
        }
    }
}
