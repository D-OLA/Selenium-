using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UseFastDotCom
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkInternetSpeed()
        {
            int waitingTime = 8500;
            By searchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(searchBar).SendKeys("www.fast.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(googleSearchButton).Click();

            webDriver.Quit();
        }
    }
}
