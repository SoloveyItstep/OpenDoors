using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(ContextDb context)
            :base(context)
        {
        }
        public IEnumerable<Photo> GetPhotosPage(int pageIndex, int pageSize)
        {
            return contextDb.Photo.Take(pageSize)
                .Skip((pageIndex - 1) * pageSize)
                .ToList();
        }

        public ContextDb contextDb { get { return context as ContextDb; } }
    }
}
