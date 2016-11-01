using OpenDoors.EntityDb;
using OpenDoors.EntityDb.Data;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenDoors.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unit)
        {
            this.unitOfWork = unit;
        }



        public ActionResult Index()
        {
            DateTime date1;
            date1 = DateTime.Now;
            var slider = unitOfWork.Slider.GetAll();
            var volunteer = unitOfWork.Volunteer.Find(vol => vol.Title.Equals("aaa"));
            ViewBag.Time = date1.Millisecond;
            return View();
        }

        public ActionResult Index2()
        {
            DateTime date = DateTime.Now;
            if (unitOfWork.Language.Find(lang => lang.Code == "en").Count() == 0)
            {
                unitOfWork.Language.Add(
                    new Language()
                    {
                        Code = "en",
                        LanguageName = "English"
                    }
                    );
                unitOfWork.Compile();
            }
            if (unitOfWork.Language.Find(lang => lang.Code == "ru").Count() == 0)
            {
                unitOfWork.Language.Add(
                new Language()
                {
                    Code = "ru",
                    LanguageName = "Russian"
                }
                );
                unitOfWork.Compile();
            }
            ViewBag.Time = (DateTime.Now - date).Milliseconds;
            return View(unitOfWork.Language.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}