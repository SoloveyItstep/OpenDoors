using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name: "Cover")]
    public class Cover
    {
        [Key]
        [Column(name: "CoverId")]
        public Int32 CoverId { get; set; }

        [MaxLength(45)]
        [Column(name: "Title")]
        public String Title { get; set; }

        [MaxLength(100)]
        [Column(name: "Description")]
        public String Description { get; set; }

        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }
    }
}
