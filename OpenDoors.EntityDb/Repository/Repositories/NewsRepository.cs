using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(ContextDb context): 
            base(context)
        {
        }

        public async Task<IQueryable<News>> GetNews(int current, int count, String language)
        {
            if (current > 0)
                --current;

            var result = context.Set<News>()
                .Where(n => n.Language.Code == language)
                .OrderByDescending(n => n.NewsId)
                .Skip(current)
                .Take(count);
            return result;
        }

        public async Task<IQueryable<News>> GetOneIncludeGallery(Int32 newsId)
        {
            var result = context.Set<News>()
                .Where(n => n.NewsId == newsId);
            return result;
        }

        public async Task<IQueryable<News>> GetPrevious(Int32 newsId)
        {
            var result = context.Set<News>()
                .OrderByDescending(n => n.NewsId)
                .Where(n => n.NewsId < newsId)
                .Take(1);
            return result;
        }

        public async Task<IQueryable<News>> GetNext(int newsId)
        {
            var result = context.Set<News>()
                .Where(n => n.NewsId > newsId)
                .Take(1);
            return result;
        }
        
    }
}
