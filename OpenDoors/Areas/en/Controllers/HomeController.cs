using Newtonsoft.Json;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenDoors.Areas.en.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;
        public HomeController(IUnitOfWork unit)
        {
            this.unitOfWork = unit;
        }
        // GET: en/Home
        public ActionResult Index()
        {
            ViewBag.lang = @"/ru/Home/Index";
            return View();
        }

        public String GetSliderJson()
        {
            var data = unitOfWork.Slider.GetAllInLanguage("en");
            return JsonConvert.SerializeObject(data);
        }
    }
}