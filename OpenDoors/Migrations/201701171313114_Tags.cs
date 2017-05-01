namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tags : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        tag = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.TagId);
            
            AddColumn("dbo.Galleries", "TagId", c => c.Int(nullable: false));
            AddColumn("dbo.News", "PreviewPhoto", c => c.String(maxLength: 250));
            AddColumn("dbo.News", "TagId", c => c.Int(nullable: false));
            CreateIndex("dbo.Galleries", "TagId");
            CreateIndex("dbo.News", "TagId");
            AddForeignKey("dbo.Galleries", "TagId", "dbo.Tags", "TagId");
            AddForeignKey("dbo.News", "TagId", "dbo.Tags", "TagId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "TagId", "dbo.Tags");
            DropForeignKey("dbo.Galleries", "TagId", "dbo.Tags");
            DropIndex("dbo.News", new[] { "TagId" });
            DropIndex("dbo.Galleries", new[] { "TagId" });
            DropColumn("dbo.News", "TagId");
            DropColumn("dbo.News", "PreviewPhoto");
            DropColumn("dbo.Galleries", "TagId");
            DropTable("dbo.Tags");
        }
    }
}
