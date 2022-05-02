using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AlliExpress_UI_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAliExpressUI()
        {
            int waitingTime = 1500;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By aliexpressLink = By.XPath("/html/body/div[7]/div/div[10]/div/div[1]/div[3]/div/div[1]/div/div/div/div[1]/a/div[1]/span");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com/");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("AliExpress login");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(aliexpressLink).Click();

            Thread.Sleep(waitingTime);

            //webDriver.Quit();
        }
    }
}
