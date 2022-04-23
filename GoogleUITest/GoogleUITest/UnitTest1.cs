using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace GoogleUITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearchStreetFighterVThenVerifyStreetFighterVIsDisplayed()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By googleResultText = By.XPath("/html/body/div[7]/div/div[10]/div[2]/div/div/div[2]/div/div[2]/div/div/div/div[2]/h2/span");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com/");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            var actualResultText = webDriver.FindElement(googleResultText);

            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));

            webDriver.Quit();
            
        }
    }
}
