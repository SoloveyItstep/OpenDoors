using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Data
{
    public class Gallery
    {
        [Key]
        public Int32 GalleryId { get; set; }

        public DateTime Date { get; set; }

        [StringLength(200)]
        public String Title { get; set; }

        public int TagId { get; set; }
        [Required]
        public virtual Tag Tag { get; set; }
        public virtual IEnumerable<Photo> Photos { get; set; }
        [Required]
        public virtual Language Language { get; set; }
        [Required]
        public virtual LanguageData LanguageData { get; set; }
    }
}
