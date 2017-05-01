using OpenDoors.EntityDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Interfaces
{
    public interface INewsRepository: IRepository<News>
    {
        Task<IQueryable<News>> GetNews(Int32 current, Int32 count, String language);

        Task<IQueryable<News>> GetOneIncludeGallery(Int32 newsId);

        Task<IQueryable<News>> GetPrevious(Int32 newsId);

        Task<IQueryable<News>> GetNext(Int32 newsId);
    }
}
