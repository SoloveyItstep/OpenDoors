using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name: "Description")]
    public class Description
    {
        [Key]
        [Column(name: "DescroptionId")]
        public Int32 DescriptionId { get; set; }

        [MaxLength(300),Required]
        [Column(name: "Title")]
        public String Title { get; set; }

        [Required]
        [Column(name: "About")]
        public String About { get; set; }

        [Column(name: "Date")]
        public DateTime Date { get; set; }

        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }
    }
}
