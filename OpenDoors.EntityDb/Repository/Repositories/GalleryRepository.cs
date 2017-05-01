using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    class GalleryRepository : Repository<Gallery>, IGalleryRepository
    {
        public GalleryRepository(ContextDb context) 
            :base(context)
        {
        }
    }
}
