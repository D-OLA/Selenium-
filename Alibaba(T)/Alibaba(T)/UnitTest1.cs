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
            int waitingTime2 = 10000;
            By googleSearchBar = By.XPath("/html[1]/body[1]/div[1]/div[3]/form[1]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]");
            By googleSearchButton = By.Name("btnK");
            By aliexpressLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[10]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/h3[1]");
            By email = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/span[1]/span[1]/input[1]");
            By password = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/span[1]/span[1]/input[1]");
            By signin = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/button[2]/span[1]");

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

            webDriver.FindElement(email).SendKeys("doolanrewaju77@yahoo.com");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(password).SendKeys("june2999");

            Thread.Sleep(waitingTime2);

            webDriver.FindElement(signin).Click();





            webDriver.Quit();
        }
    }
}
