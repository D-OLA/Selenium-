using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UseFast.com
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFast()
        {
            int waitingTime = 1500;
            By searchBar = By.Name("q");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);
            webDriver.FindElement(searchBar).SendKeys("www.fast.com");
            
        }
    }
}
