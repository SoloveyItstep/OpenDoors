using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Serializable]
    [Table(name:"Slider")]
    public class Slider
    {
        [Key]
        [Column(name: "SliderId")]
        public int SliderId { get; set; }

        [StringLength(60)]
        [Column(name: "Title")]
        public String Title { get; set; }

        [StringLength(120)]
        [Column(name: "Description")]
        public String Description { get; set; }

        [StringLength(50)]
        [Column(name: "FullName")]
        public String FullName { get; set; }

        [StringLength(200)]
        [Column(name: "Url")]
        public String Url { get; set; }

        [StringLength(7)]
        [Column(name: "DeviceType")]
        public String DeviceType { get; set; }

        public virtual Photo Photo { get; set; }
        
        [Required]
        public virtual Language Language { get; set; }

        [Required]
        [JsonIgnore]
        public virtual LanguageData LanguageData { get; set; }

    }
}
