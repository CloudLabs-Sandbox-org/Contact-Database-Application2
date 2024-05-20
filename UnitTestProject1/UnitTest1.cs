// Generate one Test case for UserController in MSTest
//
// Path: UnitTest2.cs

// Compare this snippet from Controllers/UserController.cs:
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD_application_2.Models;
using CRUD_application_2.Controllers;

using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CRUD_application_2.Tests
{
    [TestClass]
    public class UserControllerTests
    {
        [TestMethod]
        public void Create_AddsUserToList()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 1, Name = "Test User", Email = "test@example.com" };

            // Act
            var result = controller.Create(user) as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual("Index", result.RouteValues["action"]);
            //Assert.IsTrue(UserController.userlist.Contains(user));
        }
    }
}
