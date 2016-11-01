using System;
using System.Data.Entity;
using OpenDoors.EntityDb.Data;

namespace OpenDoors.EntityDb
{
    public class ContextDb:DbContext, IContextDb
    {
        public ContextDb()
            :base(@"Data Source=DESKTOP-0QC9GCN\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True")
        {
            //examples not for Context class

            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextDb>());
            //Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<ContextDb,[MigrationsClass]);

        }
        public ContextDb(String ConnectionName)
            :base(ConnectionName){ }

        public DbSet<Cover> Cover { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LanguageData> LanguageData { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Slider> Slidser { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }

    }
}
