using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [StringLength(maximumLength: 15)]
        public String LanguageName { get; set; }

        [StringLength(maximumLength:4,MinimumLength = 2)]
        public String Code { get; set; }


    }
}
