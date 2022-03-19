using _5_3_2022.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test1
{
    public class Test01
    {
        [TestCase]

        public void AddSholdProduct()
        {
            var product = new Kniga(1, "whale", "name", "izdatel", 3);
            var context = new booksContext();
            var controller = new BooksBusiness(context);

            //controller.Add(product);
        }
        
        
            [TestCase]
            public void GetAllBlogs_orders_by_Add()
            {
                var data = new List<Kniga>
            {
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
            }.AsQueryable();

            var kniga1 = new Kniga(1, "whale", "name", "izdatel", 3);
                var mockSet = new Mock<DbSet<Kniga>>();
                mockSet.As<IQueryable<Kniga>>().Setup(m => m.Provider).Returns(data.Provider);
                mockSet.As<IQueryable<Kniga>>().Setup(m => m.Expression).Returns(data.Expression);
                mockSet.As<IQueryable<Kniga>>().Setup(m => m.ElementType).Returns(data.ElementType);
                mockSet.As<IQueryable<Kniga>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

                var mockContext = new Mock<booksContext>();
                mockContext.Setup(c => c.Knigi).Returns(mockSet.Object);

                var service = new BooksBusiness(mockContext.Object);
            Kniga knigi = service.Add(product: kniga1);

                Assert.AreEqual(3, knigi.count);
            }

        [TestCase]
        public void GetAllBlogs_orders_by_Id()
        {
            var data = new List<Kniga>
            {
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
            }.AsQueryable();

            var kniga1 = new Kniga(1, "whale", "name", "izdatel", 3);
            var mockSet = new Mock<DbSet<Kniga>>();
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<booksContext>();
            mockContext.Setup(c => c.Knigi).Returns(mockSet.Object);

            var service = new BooksBusiness(mockContext.Object);
            Kniga knigi = service.Get(1);

            Assert.AreEqual("whale", knigi.Name);
        }
        [TestCase]
        public void GetAllBlogs_orders_by_Count()
        {
            var data = new List<Kniga>
            {
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
                new Kniga (1, "whale", "name", "izdatel", 3),
            }.AsQueryable();

            var kniga1 = new Kniga(1, "whale", "name", "izdatel", 3);
            var mockSet = new Mock<DbSet<Kniga>>();
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Kniga>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<booksContext>();
            mockContext.Setup(c => c.Knigi).Returns(mockSet.Object);

            var service = new BooksBusiness(mockContext.Object);
            Kniga knigi = service.GetAll();

            Assert.AreEqual(3, knigi.count);
        }

    }
    }
