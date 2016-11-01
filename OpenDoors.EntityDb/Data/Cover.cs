using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Cover
    {
        [Key]
        public Int32 CoverId { get; set; }

        [MaxLength(45)]
        public String Title { get; set; }

        [MaxLength(100)]
        public String Description { get; set; }

        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }
    }
}
