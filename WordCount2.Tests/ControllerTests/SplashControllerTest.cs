using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount2.Controllers;
using WordCount2.Models;
using System;


namespace WordCount2.Tests.ControllerTests
{
    public class SplashControllerTest
    {
        [TestMethod]
        public void Splash_ReturnsCorrectView_True()
        {

            SplashController controller = new SplashController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}
