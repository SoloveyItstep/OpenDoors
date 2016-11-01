using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDoors.EntityDb.Repository.Interfaces;
using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.Repository.Repositories;

namespace OpenDoors.EntityDb.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextDb context;

        public UnitOfWork(ContextDb context)
        {
            this.context = context;
            Language = new LanguageRepository(context);
            LanguageData = new LanguageDataRepository(context);
            Partners = new PartnerRepository(context);
            Photo = new PhotoRepository(context);
            Slider = new SliderRepository(context);
            Volunteer = new VolunteerRepository(context);
        }
        public ILanguageRepository Language { get; private set; }
        public ILanguageDataRepository LanguageData { get; private set; }
        public IPartnersRepository Partners { get; private set; }
        public IPhotoRepository Photo { get; private set; }
        public ISliderRepository Slider { get; private set; }
        public IVolunteersRepository Volunteer { get; private set; }
        public int Compile()
        {
            return context.SaveChanges();
        }

        //public void Dispose()
        //{
        //    context.Dispose();
        //}
    }
}
