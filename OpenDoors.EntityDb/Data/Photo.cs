using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDoors.EntityDb.Data
{
    [Table(name:"Photo")]
    public class Photo
    {
        [Key]
        [Column(name: "PhotoId")]
        public int PhotoId { get; set; }

        [StringLength(150)]
        [Column(name: "Path")]
        public String Path { get; set; }
    }
}
