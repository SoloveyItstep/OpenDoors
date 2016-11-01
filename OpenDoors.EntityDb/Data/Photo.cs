using System;
using System.ComponentModel.DataAnnotations;

namespace OpenDoors.EntityDb.Data
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [StringLength(150)]
        public String Path { get; set; }
    }
}
