using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanCreateBusiness()
        {
            var x = new Business("BestBuy","Main Street",10);

            Assert.IsTrue(x.Name == "BestBuy");
            Assert.IsTrue(x.Address == "Main Street");
            Assert.IsTrue(x.Customers == 10);
        }
        [Test]
        public void CannotCreateBusinessWithEmptyName1()
        {
            Assert.Catch(() =>
            {
                var x = new Business(null, "main Street", 10);
            });        
        }
        [Test]
        public void CannotCreateBusinessWithEmptyName2()
        {
            Assert.Catch(() =>
            {
                var x = new Business("", "main Street", 10);
            });
        }
    [Test]
        public void CannotCreateBusinessWithEmptyAdress1()
        {
            Assert.Catch(() =>
            {
                var x = new Business("BestBuy", null, 10);
            });
        }
    [Test]
        public void CannotCreateBusinessWithEmptyAdress2()
        {
            Assert.Catch(() =>
            {
                var x = new Business("BestBuy", "", 10);
            });
        }
        [Test]
        public void CannotCreateBusinessWithNegativeCustomers()
        {
             Assert.Catch(() =>
             {
                var x = new Business("BestBuy", "Main Street", -1);
             });
        }
    [Test]
        public void CheckLine1()
        {
             var x = new Business("BestBuy", "Main Street", 0);
             string text = "Leave the counter!";
             Assert.AreEqual(text, x.CheckLine());
        }
    [Test]
        public void CheckLine2()
        {
             var x = new Business("BestBuy", "Main Street", 3);
             string text = "Keep on good work!";
             Assert.AreEqual(text, x.CheckLine());
            
        }
    [Test]
        public void CheckLine3()
        {
            var x = new Business("BestBuy", "Main Street", 12);
            string text = "Open another counter!";
            Assert.AreEqual(text, x.CheckLine());
        }
    }
}
