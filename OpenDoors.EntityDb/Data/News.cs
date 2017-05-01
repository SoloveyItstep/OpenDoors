using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Data
{
    public class News
    {
        [Key]
        public Int32 NewsId { get; set; }

        [StringLength(200)]
        public String Title { get; set; }

        public String Information { get; set; }

        [StringLength(250)]
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
