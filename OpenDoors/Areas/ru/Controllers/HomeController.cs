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
            //ViewBag.lang = @"/en/Home/Main";
            //if (!Device())
            //    return View();
            
            List<Slider> slider = unitOfWork.Slider.
                GetAllInLanguage("ru").ToList();
            return View(slider);
        }

        public ActionResult News()
        {
            //ViewBag.PageName = "НОВОСТИ";
            ViewBag.lang = @"/en/Home/News";
            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.lang = @"/en/home/contacts";
            return View();
        }

        private Boolean Device()
        {
            string strUserAgent = Request.UserAgent.ToString().ToLower();
            if (strUserAgent != null)
            {
                if (Request.Browser.IsMobileDevice == true || strUserAgent.Contains("iphone") ||
                    strUserAgent.Contains("blackberry") || strUserAgent.Contains("mobile") ||
                    strUserAgent.Contains("windows ce") || strUserAgent.Contains("opera mini") ||
                    strUserAgent.Contains("palm") || strUserAgent.Contains("android"))
                {
                    return false;
                }
            }
            return true;
        }
    }
}