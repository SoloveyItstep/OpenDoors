using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Volunteer
    {
        [Key]
        public Int32 ValunteerId { get; set; }

        [MaxLength(60)]
        public String Title { get; set; }

        [MaxLength(120)]
        public String Description { get; set; }

        [MaxLength(50)]
        public String FullName { get; set; }

        public virtual Photo Photo { get; set; }
        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }


    }
}
