using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SteamUnlockedGamesCheck
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int waitTime = 1500;
            By searchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By SteamLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[11]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/h3[1]");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitTime);
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(waitTime);

            webDriver.FindElement(searchBar).SendKeys("SteamUnlocked.com");
            webDriver.FindElement(googleSearchButton).Click();
            Thread.Sleep(waitTime);

            webDriver.FindElement(SteamLink).Click();
            Thread.Sleep(waitTime);




            webDriver.Close();
        }

        public void TestMethod2()
        {
        }

        public void TestMethod3()
        {
        }


    }
}
