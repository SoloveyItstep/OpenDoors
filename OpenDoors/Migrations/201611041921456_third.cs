namespace OpenDoors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
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
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
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
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
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
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
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
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.LanguageDatas", t => t.LanguageData_LanguageDataId, cascadeDelete: true)
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
                .ForeignKey("dbo.Photos", t => t.Photo_PhotoId, cascadeDelete: true)
                .Index(t => t.Photo_PhotoId);
            
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserLogins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Partners", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Covers", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Volunteers", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Volunteers", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Volunteers", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Sliders", "Photo_PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Sliders", "LanguageData_LanguageDataId", "dbo.LanguageDatas");
            DropForeignKey("dbo.Sliders", "Language_LanguageId", "dbo.Languages");
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
            DropIndex("dbo.Descriptions", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Descriptions", new[] { "Language_LanguageId" });
            DropIndex("dbo.Covers", new[] { "LanguageData_LanguageDataId" });
            DropIndex("dbo.Covers", new[] { "Language_LanguageId" });
            DropTable("dbo.Partners");
            DropTable("dbo.Volunteers");
            DropTable("dbo.Photos");
            DropTable("dbo.Sliders");
            DropTable("dbo.Descriptions");
            DropTable("dbo.LanguageDatas");
            DropTable("dbo.Languages");
            DropTable("dbo.Covers");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
        }
    }
}
