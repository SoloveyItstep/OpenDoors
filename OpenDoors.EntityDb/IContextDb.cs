using OpenDoors.EntityDb.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb
{
    public interface IContextDb
    {
        DbSet<Cover> Cover { get; set; }
        DbSet<Description> Description { get; set; }
        DbSet<Language> Language { get; set; }
        DbSet<LanguageData> LanguageData { get; set; }
        DbSet<Partner> Partner { get; set; }
        DbSet<Photo> Photo { get; set; }
        DbSet<Slider> Slidser { get; set; }
        DbSet<Volunteer> Volunteer { get; set; }
    }
}
