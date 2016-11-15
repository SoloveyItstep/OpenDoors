using OpenDoors.EntityDb;
using OpenDoors.EntityDb.UnitOfWork;
using System.Web.Http;

namespace OpenDoors.Controllers
{
    public class HomeRuApiController : ApiController
    {
        IUnitOfWork unitOfWork;
        public HomeRuApiController()
        {
            unitOfWork = new UnitOfWork(new ContextDb());
        }


        //public IEnumerable<Slider> GetData()
        //{
            
        //    return Json<IEnumerable<Slider>>(unitOfWork.Slider.GetAll());            
        //}
        
    }
}