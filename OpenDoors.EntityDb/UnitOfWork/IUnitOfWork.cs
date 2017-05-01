using OpenDoors.EntityDb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.EntityDb.UnitOfWork
{
    public interface IUnitOfWork //: IDisposable
    {
        IPhotoRepository Photo { get; }
        ILanguageRepository Language { get; }
        ILanguageDataRepository LanguageData { get; }
        IPartnersRepository Partners { get; }
        ISliderRepository Slider { get; }
        IVolunteersRepository Volunteer { get; }
        INewsRepository News { get; }
        IGalleryRepository Gallery { get; }
        ITagRepository Tag { get; }

        Int32 Compile();        
    }
}
