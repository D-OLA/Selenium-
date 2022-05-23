using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UseFast.com
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFast()
        {
            int Time = 1500;
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            
        }
    }
}
