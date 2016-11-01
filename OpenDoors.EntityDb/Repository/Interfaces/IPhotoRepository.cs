using OpenDoors.EntityDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Interfaces
{
    public interface IPhotoRepository: IRepository<Photo>
    {
        IEnumerable<Photo> GetPhotosPage(int pageIndex, int pageSize);
    }
}
