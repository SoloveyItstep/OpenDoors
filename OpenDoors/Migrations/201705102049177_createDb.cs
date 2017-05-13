namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cover",
                c => new
                    {
                        CoverId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 45),
                        Description = c.String(maxLength: 100),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CoverId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(maxLength: 15),
                        Code = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.LanguageData",
                c => new
                    {
                        LanguageDataId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LanguageDataId);
            
            CreateTable(
                "dbo.Description",
                c => new
                    {
                        DescroptionId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        About = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DescroptionId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Gallery",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 200),
                        TagId = c.Int(nullable: false),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        tag = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Information = c.String(),
                        PreviewPhoto = c.String(maxLength: 250),
                        TagId = c.Int(nullable: false),
                        GalleryId = c.Int(),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.Gallery", t => t.GalleryId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.GalleryId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Slider",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Description = c.String(maxLength: 120),
                        FullName = c.String(maxLength: 50),
                        Url = c.String(maxLength: 200),
                        DeviceType = c.String(maxLength: 7),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                        Photo_PhotoId = c.Int(),
                    })
                .PrimaryKey(t => t.SliderId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .ForeignKey("dbo.Photo", t => t.Photo_PhotoId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId)
                .Index(t => t.Photo_PhotoId);
            
            CreateTable(
                "dbo.Photo",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        Path = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.PhotoId);
            
            CreateTable(
                "dbo.Volunteer",
                c => new
                    {
                        VolunteerId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Description = c.String(maxLength: 120),
                        FullName = c.String(maxLength: 50),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                        Photo_PhotoId = c.Int(),
                    })
                .PrimaryKey(t => t.VolunteerId)
                .ForeignKey("dbo.Language", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageData", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
                .ForeignKey("dbo.Photo", t => t.Photo_PhotoId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId)
                .Index(t => t.Photo_PhotoId);
            
            CreateTable(
                "dbo.Partner",
                c => new
                    {
                        PartnerId = c.Int(nullable: false, identity: true),
                        Photo_PhotoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartnerId)
                .ForeignKey("dbo.Photo", t => t.Photo_PhotoId, cascadeDelete: true)
                .Index(t => t.Photo_PhotoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partner", "Photo_PhotoId", "dbo.Photo");
            DropForeignKey("dbo.Cover", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.Volunteer", "Photo_PhotoId", "dbo.Photo");
            DropForeignKey("dbo.Volunteer", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.Volunteer", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.Slider", "Photo_PhotoId", "dbo.Photo");
            DropForeignKey("dbo.Slider", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.Slider", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.News", "TagId", "dbo.Tag");
            DropForeignKey("dbo.News", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.News", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.News", "GalleryId", "dbo.Gallery");
            DropForeignKey("dbo.Gallery", "TagId", "dbo.Tag");
            DropForeignKey("dbo.Gallery", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.Gallery", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.Description", "LanguageData_LanguageDataId", "dbo.LanguageData");
            DropForeignKey("dbo.Description", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.Cover", "Language_LanguageId", "dbo.Language");
            DropIndex("dbo.Partner", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Volunteer", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Volunteer", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Volunteer", new[] { "Language_LanguageId" });
            DropIndex("dbo.Slider", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Slider", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Slider", new[] { "Language_LanguageId" });
            DropIndex("dbo.News", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.News", new[] { "Language_LanguageId" });
            DropIndex("dbo.News", new[] { "GalleryId" });
            DropIndex("dbo.News", new[] { "TagId" });
            DropIndex("dbo.Gallery", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Gallery", new[] { "Language_LanguageId" });
            DropIndex("dbo.Gallery", new[] { "TagId" });
            DropIndex("dbo.Description", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Description", new[] { "Language_LanguageId" });
            DropIndex("dbo.Cover", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Cover", new[] { "Language_LanguageId" });
            DropTable("dbo.Partner");
            DropTable("dbo.Volunteer");
            DropTable("dbo.Photo");
            DropTable("dbo.Slider");
            DropTable("dbo.News");
            DropTable("dbo.Tag");
            DropTable("dbo.Gallery");
            DropTable("dbo.Description");
            DropTable("dbo.LanguageData");
            DropTable("dbo.Language");
            DropTable("dbo.Cover");
        }
    }
}
