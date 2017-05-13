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
            //IUnitOfWork unitOfWork = new UnitOfWork(new ContextDb(@"Data Source=DESKTOP-4PI41MR\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True"));

            //Language en = new Language() { Code = "en", LanguageName = "English" };
            //Language ru = new Language() { Code = "ru", LanguageName = "Russian" };
            //unitOfWork.Language.Add(en);
            //unitOfWork.Language.Add(ru);
            //unitOfWork.Compile();
            ////==================================
            //List<Photo> photo = new List<Photo>() {
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner1.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner2.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner3.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner4.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner1_m.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner2_m.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner3_m.jpg"
            //    },
            //    new Photo {
            //        Path = @"\Content\Images\Carousel\banner4_m.jpg"
            //    },
            //};
            //unitOfWork.Photo.AddRange(photo);
            //unitOfWork.Compile();
            //============================================
            //IEnumerable<Slider> sl = unitOfWork.Slider.GetAll();

            //Language lang = unitOfWork.Language.Find(l => l.Code == "en")
            //    .FirstOrDefault();

            //List<Photo> ph = unitOfWork.Photo.GetAll().ToList();
            //for (var i = 0; i < 4; ++i)
            //{


            //    unitOfWork.Slider.Add(
            //            new Slider()
            //            {
            //                Title = "I have a new family that loves and helps along the way ...",
            //                Description = "Varied and rich experience in the scope and location of training staff provides wide range of participation in formation",
            //                FullName = "Natasha Ivanova",
            //                Language = lang,
            //                Photo = ph[i],
            //                Url = "/Home/Index",
            //                LanguageData = new LanguageData()
            //                {

            //                }
            //            }
            //        );
            //}
            //unitOfWork.Compile();
            //Language ru = unit.Language.Find(l => l.Code == "ru").First();
            //Language en = unit.Language.Find(l => l.Code == "en").First();
            //var ph = unit.Photo.GetAll().ToList();


            //var slider1 = new Slider
            //{
            //    Title = "Выпускники интерната",
            //    Description = "Сирота – не приговор, если у тебя есть заботливые друзья. Мне они помогли найти себя и поддерживают с любовью.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[0],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider2 = new Slider
            //{
            //    Title = "Помощь детям-сиротам",
            //    Description = "Я в семье -7й. Нас отдали в интернат, так как нечем кормить. Когда приезжает наставник, он привозит сладости.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[1],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider3 = new Slider
            //{
            //    Title = "Усыновление",
            //    Description = "Теперь у меня есть семья. Никогда не поздно мечтать о любящих родителях!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[2],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider4 = new Slider
            //{
            //    Title = "Дневной центр «Компас»",
            //    Description = "Место, где я могу весело и полезно провести время и приобрести новых друзей!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[3],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider1 = new Slider
            //{
            //    Title = "Transition Home for orphanage graduates",
            //    Description = "Orphan is not a doom if you have caring friends. These people help me find strength to live and support me with love.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[0],
            //    LanguageData = new LanguageData()
            //};

            //var slider2 = new Slider
            //{
            //    Title = "Helping Orphans and disabled kids",
            //    Description = "I am 7th kid in my family. We lacked food at home. I was taken to orphanage where mentor visits me.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[1],
            //    LanguageData = new LanguageData()
            //};

            //var slider3 = new Slider
            //{
            //    Title = "Adoption facilitation",
            //    Description = "Now I have a family! It is never too late to dream of having loving parents!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[2],
            //    LanguageData = new LanguageData()
            //};

            //var slider4 = new Slider
            //{
            //    Title = "Center for in-crisis families",
            //    Description = "It is a place where I can have fun and quality time and make new friends!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[3],
            //    LanguageData = new LanguageData()
            //};

            //unit.Slider.Add(slider1);
            //unit.Slider.Add(slider2);
            //unit.Slider.Add(slider3);
            //unit.Slider.Add(slider4);

            //unit.Compile();
            //Assert.IsNotNull("");
        }

        [TestMethod]
        public void CreateSlider()
        {
            //IUnitOfWork unitOfWork = new UnitOfWork(new ContextDb(@"Data Source=DESKTOP-4PI41MR\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True"));

            //Language ru = unit.Language.Find(l => l.Code == "ru").First();
            //Language en = unit.Language.Find(l => l.Code == "en").First();
            //var ph = unit.Photo.GetAll().ToList();


            //var slider1slideRuDesc1 = new Slider
            //{
            //    Title = "Выпускники интерната",
            //    Description = "Сирота – не приговор, если у тебя есть заботливые друзья. Мне они помогли найти себя и поддерживают с любовью.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[0],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider1slideRuDesc2 = new Slider
            //{
            //    Title = "Помощь детям-сиротам",
            //    Description = "Я в семье -7й. Нас отдали в интернат, так как нечем кормить. Когда приезжает наставник, он привозит сладости.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[1],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider1slideRuDesc3 = new Slider
            //{
            //    Title = "Усыновление",
            //    Description = "Теперь у меня есть семья. Никогда не поздно мечтать о любящих родителях!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[2],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var slider1slideRuDesc4 = new Slider
            //{
            //    Title = "Дневной центр «Компас»",
            //    Description = "Место, где я могу весело и полезно провести время и приобрести новых друзей!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[3],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};
            ////========Mob===========
            //var slider1slideRuMob1 = new Slider
            //{
            //    Title = "Выпускники интерната",
            //    Description = "Сирота – не приговор, если у тебя есть заботливые друзья. Мне они помогли найти себя и поддерживают с любовью.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[4],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //var slider1slideRuMob2 = new Slider
            //{
            //    Title = "Помощь детям-сиротам",
            //    Description = "Я в семье -7й. Нас отдали в интернат, так как нечем кормить. Когда приезжает наставник, он привозит сладости.",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[5],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //var slider1slideRuMob3 = new Slider
            //{
            //    Title = "Усыновление",
            //    Description = "Теперь у меня есть семья. Никогда не поздно мечтать о любящих родителях!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[6],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //var slider1slideRuMob4 = new Slider
            //{
            //    Title = "Дневной центр «Компас»",
            //    Description = "Место, где я могу весело и полезно провести время и приобрести новых друзей!",
            //    Url = "#",
            //    FullName = "",
            //    Language = ru,
            //    Photo = ph[7],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //unit.Slider.Add(slider1slideRuDesc1);
            //unit.Slider.Add(slider1slideRuDesc2);
            //unit.Slider.Add(slider1slideRuDesc3);
            //unit.Slider.Add(slider1slideRuDesc4);
            //unit.Slider.Add(slider1slideRuMob1);
            //unit.Slider.Add(slider1slideRuMob2);
            //unit.Slider.Add(slider1slideRuMob3);
            //unit.Slider.Add(slider1slideRuMob4);


            //=======================ENG===============================
            //var sliderEnDesc1 = new Slider
            //{
            //    Title = "Transition Home for orphanage graduates",
            //    Description = "Orphan is not a doom if you have caring friends. These people help me find strength to live and support me with love.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[0],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var sliderEnDesc2 = new Slider
            //{
            //    Title = "Helping Orphans and disabled kids",
            //    Description = "I am 7th kid in my family. We lacked food at home. I was taken to orphanage where mentor visits me.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[1],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var sliderEnDesc3 = new Slider
            //{
            //    Title = "Adoption facilitation",
            //    Description = "Now I have a family! It is never too late to dream of having loving parents!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[2],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            //var sliderEnDesc4 = new Slider
            //{
            //    Title = "Center for in-crisis families",
            //    Description = "It is a place where I can have fun and quality time and make new friends!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[3],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "desctop"
            //};

            ////===========Mob==========
            //var sliderEnMob1 = new Slider
            //{
            //    Title = "Transition Home for orphanage graduates",
            //    Description = "Orphan is not a doom if you have caring friends. These people help me find strength to live and support me with love.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[4],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //var sliderEnMob2 = new Slider
            //{
            //    Title = "Helping Orphans and disabled kids",
            //    Description = "I am 7th kid in my family. We lacked food at home. I was taken to orphanage where mentor visits me.",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[5],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //var sliderEnMob3 = new Slider
            //{
            //    Title = "Adoption facilitation",
            //    Description = "Now I have a family! It is never too late to dream of having loving parents!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[6],
            //    LanguageData = new LanguageData()
            //    ,
            //    DeviceType = "mobile"
            //};

            //var sliderEnMob4 = new Slider
            //{
            //    Title = "Center for in-crisis families",
            //    Description = "It is a place where I can have fun and quality time and make new friends!",
            //    Url = "#",
            //    FullName = "",
            //    Language = en,
            //    Photo = ph[7],
            //    LanguageData = new LanguageData(),
            //    DeviceType = "mobile"
            //};

            //unit.Slider.Add(sliderEnDesc1);
            //unit.Slider.Add(sliderEnDesc2);
            //unit.Slider.Add(sliderEnDesc3);
            //unit.Slider.Add(sliderEnDesc4);
            //unit.Slider.Add(sliderEnMob1);
            //unit.Slider.Add(sliderEnMob2);
            //unit.Slider.Add(sliderEnMob3);
            //unit.Slider.Add(sliderEnMob4);

            //unit.Compile();
            Assert.IsNotNull("");
        }

        [TestMethod]
        public void CreateNews()
        {
            //IUnitOfWork unitOfWork = new UnitOfWork(new ContextDb(@"Data Source=DESKTOP-4PI41MR\SQLEXPRESS;Initial Catalog=OpenDoorsFund;Integrated Security=True"));

            //Language lang = unitOfWork.Language.Find(x => x.Code == "ru").FirstOrDefault();

            //Tag tag = new Tag
            //{
            //    tag = "tag name 1"
            //};
            //Tag tag1 = new Tag
            //{
            //    tag = "tag name 2"
            //};
            //Tag tag2 = new Tag
            //{
            //    tag = "tag name 3"
            //};
            //Tag tag3 = new Tag
            //{
            //    tag = "tag name 4"
            //};
            //unitOfWork.Tag.Add(tag);
            //unitOfWork.Tag.Add(tag1);
            //unitOfWork.Tag.Add(tag2);
            //unitOfWork.Tag.Add(tag3);
            //unitOfWork.Compile();

            ////==========================================
            //var tags = unitOfWork.Tag.GetAll().ToList();
            //for(Int32 i = 0; i < 25; ++i) {
            //var news = new News
            //{
            //    Information = "Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel. Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.",
            //    Language = lang,
            //    PreviewPhoto = @"/Content/Images/News/NewsPreview.jpg",
            //    Title = "Test News",
            //    Tag = tags[0],
            //    TagId = 1,
            //    LanguageData = new LanguageData()
            //};
            //unitOfWork.News.Add(news);
            //var news1 = new News
            //{
            //    Information = "Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel. Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.",
            //    Language = lang,
            //    PreviewPhoto = @"/Content/Images/News/NewsPreview.jpg",
            //    Title = "Test News",
            //    Tag = tags[1],
            //    LanguageData = new LanguageData()
            //};
            //unitOfWork.News.Add(news1);
            //var news2 = new News
            //{
            //    Information = "Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel. Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.",
            //    Language = lang,
            //    PreviewPhoto = @"/Content/Images/News/NewsPreview.jpg",
            //    Title = "Test News",
            //    Tag = tags[0],
            //    LanguageData = new LanguageData()
            //};
            //unitOfWork.News.Add(news2);
            //var news3 = new News
            //{
            //    Information = "Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel. Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.",
            //    Language = lang,
            //    PreviewPhoto = @"/Content/Images/News/NewsPreview.jpg",
            //    Title = "Test News",
            //    Tag = tags[0],
            //    LanguageData = new LanguageData()
            //};
            //unitOfWork.News.Add(news3);
            //unitOfWork.Compile();
          //}
        }
    }

}
