using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"Volunteer")]
    public class Volunteer
    {
        [Key]
        [Column(name: "VolunteerId")]
        public Int32 ValunteerId { get; set; }

        [MaxLength(60)]
        [Column(name: "Title")]
        public String Title { get; set; }

        [MaxLength(120)]
        [Column(name: "Description")]
        public String Description { get; set; }

        [MaxLength(50)]
        [Column(name: "FullName")]
        public String FullName { get; set; }

        public virtual Photo Photo { get; set; }
        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }


    }
}
