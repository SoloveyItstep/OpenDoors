using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"News")]
    public class News
    {
        [Key]
        [Column(name: "NewsId")]
        public Int32 NewsId { get; set; }

        [StringLength(200)]
        [Column(name: "Title")]
        public String Title { get; set; }

        [Column(name: "Information")]
        public String Information { get; set; }

        [StringLength(250)]
        [Column(name: "PreviewPhoto")]
        public String PreviewPhoto { get; set; }

        public Int32 TagId { get; set; }
        public virtual Tag Tag { get; set; }

        
        public Int32? GalleryId { get; set; }
        public virtual Gallery Gallery { get; set; }
        [Required]
        [JsonIgnore]
        public virtual Language Language { get; set; }
        [Required]
        [JsonIgnore]
        public virtual LanguageData LanguageData { get; set; }
    }
}
