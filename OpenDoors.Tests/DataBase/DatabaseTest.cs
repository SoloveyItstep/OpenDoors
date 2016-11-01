using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using OpenDoors.EntityDb;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDoors.Tests.DataBase
{
    [TestClass]
    public class DatabaseTest
    {
        IUnitOfWork unit;
        public DatabaseTest()
        {
            var item = new NinjModule();
            var kernel = new StandardKernel(item);
            this.unit = kernel.Get<IUnitOfWork>();
        }

        [TestMethod]
        public void DbTestInject()
        {
            var item = unit.Photo.GetAll();

            DateTime date1, date2;
            date1 = DateTime.Now;
            var tmp = unit.Language.GetAll();
            Debug.Print("Start time --- {0}", date1.Millisecond);

            date2 = DateTime.Now;
            string total = (date2 - date1).TotalMilliseconds.ToString();
            Debug.Print("Total time --- {0}", total);
        }

        [TestMethod]
        public void DbTest()
        {
            IUnitOfWork un = new UnitOfWork(new ContextDb());
            var item = un.Photo.GetAll();

            DateTime date1, date2;
            date1 = DateTime.Now;
            var tmp = un.Language.GetAll();
            Debug.Print("Start time 1 --- {0}", date1.Millisecond);

            date2 = DateTime.Now;
            string total = (date2 - date1).TotalMilliseconds.ToString();
            Debug.Print("Total time 1 --- {0}", total);
        }
    }
}
