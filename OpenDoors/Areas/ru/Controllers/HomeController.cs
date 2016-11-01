using Newtonsoft.Json;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace OpenDoors.Areas.ru.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;
        public HomeController(IUnitOfWork unit)
        {
            this.unitOfWork = unit;
        }
        // GET: ru/Home
        public ActionResult Index()
        {
            return View();
        }

        public String GetSliderJson()
        {
            var data = unitOfWork.Slider.GetAllInLanguage("ru");
            return JsonConvert.SerializeObject(data);
        }
    }
}