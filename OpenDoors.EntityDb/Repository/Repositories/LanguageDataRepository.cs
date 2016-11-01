using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    public class LanguageDataRepository : Repository<LanguageData>, ILanguageDataRepository
    {
        public LanguageDataRepository(ContextDb context) 
            :base(context)
        {
        }
    }
}
