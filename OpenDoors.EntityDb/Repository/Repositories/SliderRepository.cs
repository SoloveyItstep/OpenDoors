﻿using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.Repository.Repositories
{
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {
        public SliderRepository(ContextDb context) 
            :base(context)
        {
        }

        public IEnumerable<Slider> GetAllInLanguage(string languageCode)
        {
            var data = context.Set<Slider>().Where(sl => sl.Language.Code == languageCode)
                .Include(inc => inc.Photo)
                .ToList();
            return data;
        }
    }
}
