using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCount2.Controllers;
using WordCount2.Models;
using System;


namespace WordCount2.Tests
{
    public class CounterControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            
            CounterController controller = new CounterController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Input_ReturnsCorrectView_True()
        {
            CounterController controller = new CounterController();
            ActionResult indexView = controller.InputList();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    
    }
}
