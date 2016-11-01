using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Partner
    {
        [Key]
        public Int32 PartnerId { get; set; }

        [Required]
        public virtual Photo Photo { get; set; }
    }
}
