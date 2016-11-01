using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class LanguageData
    {
        public LanguageData()
        {
            Sliders = new HashSet<Slider>();
            Volunteers = new HashSet<Volunteer>();
            Covers = new HashSet<Cover>();
            Descriptions = new HashSet<Description>();
        }

        [Key]
        public Int32 LanguageDataId { get; set; }

        public virtual ICollection<Slider> Sliders { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
        public virtual ICollection<Cover> Covers { get; set; }
        public virtual ICollection<Description> Descriptions { get; set; }
    }
}
