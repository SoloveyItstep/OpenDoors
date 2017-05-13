using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"Language")]
    public class Language
    {
        [Key]
        [Column(name: "LanguageId")]
        public int LanguageId { get; set; }

        [Column(name: "LanguageName")]
        [StringLength(maximumLength: 15)]
        public String LanguageName { get; set; }

        [Column(name: "Code")]
        [StringLength(maximumLength:4,MinimumLength = 2)]
        public String Code { get; set; }


    }
}
