using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDoors;
using OpenDoors.Controllers;
using OpenDoors.EntityDb.UnitOfWork;
using System.Diagnostics;
using Ninject.Modules;
using Ninject;
using OpenDoors.EntityDb;
using OpenDoors.Tests.DataBase;
using OpenDoors.EntityDb.Data;

namespace OpenDoors.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        IUnitOfWork unit;
        public HomeControllerTest()
        {
            var item = new NinjModule();
            var kernel = new StandardKernel(item);
            this.unit = kernel.Get<IUnitOfWork>();
        }
        
        //[TestMethod]
        //public void IndexInject()
        //{

        //    // Arrange
        //    HomeController controller = new HomeController(unit);
        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);

        //}

        //[TestMethod]
        //public void Index()
        //{

        //    // Arrange
        //    HomeController controller = new HomeController(new UnitOfWork(new ContextDb("LocalDb")));

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);

        //}

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController(unit);

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    //HomeController controller = new HomeController(unit);

        //    //// Act
        //    //ViewResult result = controller.Contact() as ViewResult;

        //    //// Assert
        //    //Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void DbTest()
        {
            IUnitOfWork unitOfWork = new UnitOfWork(new ContextDb(@"Data Source=DESKTOP-0QC9GCN\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True"));

            Language en = new Language() { Code = "en", LanguageName = "English" };
            Language ru = new Language() { Code = "ru", LanguageName = "Russian" };
            unitOfWork.Language.Add(en);
            unitOfWork.Language.Add(ru);
            unitOfWork.Compile();

            List<Photo> photo = new List<Photo>() {
                new Photo {
                    Path = @"\Content\Images\Carousel\banner1.jpg"
                },
                new Photo {
                    Path = @"\Content\Images\Carousel\banner2.jpg"
                },
                new Photo {
                    Path = @"\Content\Images\Carousel\banner3.jpg"
                },
                new Photo {
                    Path = @"\Content\Images\Carousel\banner4.jpg"
                },
            };
            unitOfWork.Photo.AddRange(photo);
            unitOfWork.Compile();

            IEnumerable<Slider> sl = unitOfWork.Slider.GetAll();

            Language lang = unitOfWork.Language.Find(l => l.Code == "ru")
                .FirstOrDefault();
            
            List<Photo> ph = unitOfWork.Photo.GetAll().ToList();
            for (var i = 0; i < 4; ++i)
            {
                

                unitOfWork.Slider.Add(
                        new Slider()
                        {
                            Title = "У меня есть новая семья, которая любит и помагает в пути...",
                            Description = "Разнообразный и богатый опыт рамки и место обучения кадров обеспечивает широкому кругу участие в формировании",
                            FullName = "Наташа Иванова",
                            Language = lang,
                            Photo = ph[i],
                            Url = "/Home/Index",
                            LanguageData = new LanguageData()
                            {

                            }
                        }
                    );
            }
            unitOfWork.Compile();

            Assert.IsNotNull(lang);
        }
    }

}
