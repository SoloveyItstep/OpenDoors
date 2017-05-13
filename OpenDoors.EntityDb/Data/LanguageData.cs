using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name: "LanguageData")]
    public class LanguageData
    {
        public LanguageData()
        {
            Sliders = new HashSet<Slider>();
            Volunteers = new HashSet<Volunteer>();
            Covers = new HashSet<Cover>();
            Descriptions = new HashSet<Description>();
            Gallery = new HashSet<Gallery>();
            News = new HashSet<News>();
        }

        [Key]
        [Column(name: "LanguageDataId")]
        public Int32 LanguageDataId { get; set; }

        public virtual ICollection<Slider> Sliders { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
        public virtual ICollection<Cover> Covers { get; set; }
        public virtual ICollection<Description> Descriptions { get; set; }
        public virtual ICollection<Gallery> Gallery { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
