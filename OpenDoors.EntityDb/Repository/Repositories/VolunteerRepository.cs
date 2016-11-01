using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    public class VolunteerRepository : Repository<Volunteer>, IVolunteersRepository
    {
        public VolunteerRepository(ContextDb context) 
            :base(context)
        {
        }
    }
}
