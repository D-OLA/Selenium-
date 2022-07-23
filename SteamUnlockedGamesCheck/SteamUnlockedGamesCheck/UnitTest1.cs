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
            By googleSearchButton = By.XPath("/html[1]/body[1]/div[1]/div[3]/form[1]/div[1]/div[1]/div[3]/center[1]/input[1]");
            By SteamLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[10]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/h3[1]");
            By SteamUnlockedSearch = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/input[1]");

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

            webDriver.FindElement(SteamUnlockedSearch).SendKeys("FIFA 22");
            webDriver.FindElement(SteamUnlockedSearch).SendKeys(Keys.Enter);


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
