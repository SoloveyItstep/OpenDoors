using Newtonsoft.Json;
using OpenDoors.EntityDb.Data;
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
            ViewBag.lang = @"/en/Home/Index";
            return View();
        }

        public String GetSliderJson()
        {
            var data = unitOfWork.Slider.GetAllInLanguage("ru");
            return JsonConvert.SerializeObject(data);
        }

        public ActionResult Main()
        {
            ViewBag.lang = @"/en/Home/Main";
            List<Slider> slider = unitOfWork.Slider.
                GetAllInLanguage("ru").ToList();
            return View(slider);
        }
    }
}