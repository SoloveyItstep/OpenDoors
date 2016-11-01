using OpenDoors.EntityDb;
using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.UnitOfWork;
using System.Collections.Generic;
using System.Web.Http;

namespace OpenDoors.Areas.ru.Controllers
{
    public class HomeApiController : ApiController
    {
        IUnitOfWork unitOfWork;
        public HomeApiController()
        {
            unitOfWork = new UnitOfWork(new ContextDb());
        }

        public IEnumerable<Slider> GetData()
        {
            return new List<Slider>() { new Slider() { Title = "title", Description = "Descr",
                FullName = "name", Language = new Language(), Photo = new Photo(), SliderId = 1 } };
            //return unitOfWork.Slider.GetAll();
        }

    }
}