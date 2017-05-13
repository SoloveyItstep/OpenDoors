using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"Tag")]
    public class Tag
    {
        [Key]
        [Column(name: "TagId")]
        public Int32 TagId { get; set; }

        [StringLength(30)]
        [Column(name: "tag")]
        public String tag { get; set; }

        public virtual IEnumerable<News> News { get; set; }
        public virtual IEnumerable<Gallery> Gallery { get; set; }

    }
}
