using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Webdriver_Practice_Facebook_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFacebookAndPrintFriendsList()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK"); 
            
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Minimize();

            Thread.Sleep(waitingTime);
        }
    }
}
