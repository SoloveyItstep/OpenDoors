using OpenDoors.EntityDb;
using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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