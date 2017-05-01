using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Newtonsoft.Json;
using OpenDoors.EntityDb;
using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Script.Serialization;

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
            //return new List<Slider>() { new Slider() { Title = "title", Description = "Descr",
            //    FullName = "name", Language = new Language(), Photo = new Photo(), SliderId = 1 } };
            return unitOfWork.Slider.GetAllInLanguage("ru");
        }

        [Route("api/news/{current:int}/{count:int}/{language}")]
        public String GetNews(int current, int count, String language)
        {
            List<News> arr = unitOfWork.News.GetNews(current, count, language)
                .Result.ToList();
            //List<News> arr = unitOfWork.News.GetAll().ToList();
            var response = JsonConvert.SerializeObject(arr);
            return response;
        }


    }
}