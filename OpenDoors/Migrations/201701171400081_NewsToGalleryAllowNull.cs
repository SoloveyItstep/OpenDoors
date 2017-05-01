namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewsToGalleryAllowNull : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.News", new[] { "GalleryId" });
            AlterColumn("dbo.News", "GalleryId", c => c.Int());
            CreateIndex("dbo.News", "GalleryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.News", new[] { "GalleryId" });
            AlterColumn("dbo.News", "GalleryId", c => c.Int(nullable: false));
            CreateIndex("dbo.News", "GalleryId");
        }
    }
}
