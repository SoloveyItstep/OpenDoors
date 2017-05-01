namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagsLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Galleries", "Title", c => c.String(maxLength: 200));
            AlterColumn("dbo.Tags", "tag", c => c.String(maxLength: 30));
            AlterColumn("dbo.News", "Title", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Title", c => c.String(maxLength: 120));
            AlterColumn("dbo.Tags", "tag", c => c.String(maxLength: 10));
            AlterColumn("dbo.Galleries", "Title", c => c.String(maxLength: 120));
        }
    }
}
