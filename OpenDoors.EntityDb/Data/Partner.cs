using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"Partner")]
    public class Partner
    {
        [Key]
        [Column(name: "PartnerId")]
        public Int32 PartnerId { get; set; }

        [Required]
        public virtual Photo Photo { get; set; }
    }
}
