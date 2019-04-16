using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WorkingWithVisualStudio.Tests
{
    [TestClass]
    public class HomeControllerTests
    {

        [TestMethod]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Assert.AreEqual(SimpleRepository.SharedRepository.Products, model,
               Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
    }
}