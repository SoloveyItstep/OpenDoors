using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Description
    {
        [Key]
        public Int32 DescriptionId { get; set; }

        [MaxLength(300),Required]
        public String Title { get; set; }

        [Required]
        public String About { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }
    }
}
