﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBotMiddleWare;
using ChatBotMiddleWare.Controllers;

namespace ChatBotMiddleWare.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disposer
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Affirmer
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
