using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Data
{
    public class Tag
    {
        [Key]
        public Int32 TagId { get; set; }

        [StringLength(30)]
        public String tag { get; set; }

        public virtual IEnumerable<News> News { get; set; }
        public virtual IEnumerable<Gallery> Gallery { get; set; }

    }
}
