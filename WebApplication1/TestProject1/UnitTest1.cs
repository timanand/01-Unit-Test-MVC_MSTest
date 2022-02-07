using Microsoft.VisualStudio.TestTools.UnitTesting;


// Added by AANA
using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using WebApplication1.Controllers;
using WebApplication1.Models;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StaffController controller = new StaffController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void About()
        {
            StaffController controller = new StaffController();

            ViewResult result = controller.About() as ViewResult;

            //Assert.AreEqual("Your application", result.ViewData["Title"]);
            Assert.AreEqual("Your application description page.", result.ViewData["Title"]);
        }


        [TestMethod]
        public void TestIndexMethod()
        {

            // Arrange
            var controller = new StaffController();

            string viewName = "Index";

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual(viewName, result.ViewName);

        }


        [TestMethod]
        public void TestZZZMethod()
        {
            // Arrange
            var controller = new StaffController();

            //string viewName = "zzz";
            string name = "Nitish";

            // Act
            var result = controller.zzz() as ViewResult;
            var model = (Employee)result.Model;

            // Assert
            //Assert.AreEqual(viewName, result.ViewName);
            Assert.AreEqual(name, model.Name);

        }





    }
}
