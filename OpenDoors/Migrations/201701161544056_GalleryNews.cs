namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GalleryNews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        CoverId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 45),
                        Description = c.String(maxLength: 100),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CoverId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(maxLength: 15),
                        Code = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.LanguageDatas",
                c => new
                    {
                        LanguageDataId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LanguageDataId);
            
            CreateTable(
                "dbo.Descriptions",
                c => new
                    {
                        DescriptionId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        About = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DescriptionId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 120),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 120),
                        Information = c.String(),
                        GalleryId = c.Int(nullable: false),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.Galleries", t => t.GalleryId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .Index(t => t.GalleryId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Description = c.String(maxLength: 120),
                        FullName = c.String(maxLength: 50),
                        Url = c.String(maxLength: 200),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                        Photo_PhotoId = c.Int(),
                    })
                .PrimaryKey(t => t.SliderId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .ForeignKey("dbo.Photos", t => t.Photo_PhotoId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId)
                .Index(t => t.Photo_PhotoId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        Path = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.PhotoId);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        ValunteerId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Description = c.String(maxLength: 120),
                        FullName = c.String(maxLength: 50),
                        Language_LanguageId = c.Int(nullable: false),
                        LanguageData_LanguageDataId = c.Int(nullable: false),
                        Photo_PhotoId = c.Int(),
                    })
                .PrimaryKey(t => t.ValunteerId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId)
                .ForeignKey("dbo.Photos", t => t.Photo_PhotoId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.LanguageData_LanguageDataId)
                .Index(t => t.Photo_PhotoId);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        PartnerId = c.Int(nullable: false, identity: true),
                        Photo_PhotoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartnerId)
                .ForeignKey("dbo.Photos", t => t.Photo_PhotoId)
                .Index(t => t.Photo_PhotoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partners", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Covers", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Volunteers", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Volunteers", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Volunteers", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Sliders", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Sliders", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Sliders", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.News", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.News", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.News", "GalleryId", "dbo.Galleries");
            DropForeignKey("dbo.Galleries", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Galleries", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Descriptions", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Descriptions", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Covers", "Language_LanguageId", "dbo.Languages");
            DropIndex("dbo.Partners", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Volunteers", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Volunteers", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Volunteers", new[] { "Language_LanguageId" });
            DropIndex("dbo.Sliders", new[] { "Photo_PhotoId" });
            DropIndex("dbo.Sliders", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Sliders", new[] { "Language_LanguageId" });
            DropIndex("dbo.News", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.News", new[] { "Language_LanguageId" });
            DropIndex("dbo.News", new[] { "GalleryId" });
            DropIndex("dbo.Galleries", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Galleries", new[] { "Language_LanguageId" });
            DropIndex("dbo.Descriptions", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Descriptions", new[] { "Language_LanguageId" });
            DropIndex("dbo.Covers", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Covers", new[] { "Language_LanguageId" });
            DropTable("dbo.Partners");
            DropTable("dbo.Volunteers");
            DropTable("dbo.Photos");
            DropTable("dbo.Sliders");
            DropTable("dbo.News");
            DropTable("dbo.Galleries");
            DropTable("dbo.Descriptions");
            DropTable("dbo.LanguageDatas");
            DropTable("dbo.Languages");
            DropTable("dbo.Covers");
        }
    }
}
