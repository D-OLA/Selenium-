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
        public void TestAliExpressUiAndAddItemsToCart()
        {
            int waitingTime = 1500;
            By googleSearchBar = By.XPath("/html[1]/body[1]/div[1]/div[3]/form[1]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]");
            By googleSearchButton = By.Name("Btnk");
            By aliexpressLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[10]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/div[1]/span[1]");
            By wishLink = By.XPath("/html/body/div[2]/div[3]/div/div[2]/div[5]/div[2]/a/span");

            IWebDriver webDriver = new ChromeDriver();
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

            webDriver.FindElement(wishLink).Click();



            //webDriver.Quit();
        }
    }
}
