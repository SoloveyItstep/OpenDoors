using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    [Serializable]
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }

        [StringLength(60)]
        public String Title { get; set; }

        [StringLength(120)]
        public String Description { get; set; }

        [StringLength(50)]
        public String FullName { get; set; }

        public virtual Photo Photo { get; set; }
        
        [Required]
        public virtual Language Language { get; set; }

        [Required]
        [JsonIgnore]
        public virtual LanguageData LanguageData { get; set; }

    }
}
