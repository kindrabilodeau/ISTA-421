using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio1.Tests
{
    [TestClass]
    public class ProductTests
    {

        [TestMethod]
        public void CanChangeProductName()
        {

            // Arrange
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            p.Name = "New Name";

            //Assert
            Assert.AreEqual("New Name", p.Name);
        }

        [TestMethod]
        public void CanChangeProductPrice()
        {

            // Arrange
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            p.Price = 200M;

            //Assert
            Assert.AreEqual(200M, p.Price);
        }
    }
}
