using System;
using System.Data.Entity;
using OpenDoors.EntityDb.Data;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OpenDoors.EntityDb
{
    public class ContextDb : DbContext, IContextDb
    {
        public ContextDb()
            : base(@"Data Source=DESKTOP-4PI41MR\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True")
        {
            //examples not for Context class

            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextDb>());
            //Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<ContextDb,[MigrationsClass]);

        }
        public ContextDb(String ConnectionName)
            : base(ConnectionName)
        {
            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextDb>());
            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextDb>());
        }

        public DbSet<Cover> Cover { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LanguageData> LanguageData { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Slider> Slidser { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<ContextDb>(null);
        //}
    }
}
