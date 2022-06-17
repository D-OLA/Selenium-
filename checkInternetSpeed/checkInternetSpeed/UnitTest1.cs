using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace checkInternetSpeed
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkInternetSpeed()
        {
            int waitTime = 1800;
            int waitTime2 = 28000;
            By searchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By fastLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[10]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/h3[1]");
            By refresh = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/span[1]");
            By moreInfo = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[1]/a[1]");
            By resultText1 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[2]/div[2]/div[1]/span[2]");
            By settings = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[2]/table[1]/tbody[1]/tr[1]/td[1]/a[1]/span[2]");
            By minDur = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[3]/div[2]/input[1]");
            By maxDur = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[3]/div[2]/input[2]");
            By saveChanges = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[4]/div[3]/div[4]/a[2]");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitTime);
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitTime);
            webDriver.Navigate().GoToUrl("https://google.com");

            Thread.Sleep(waitTime);
            webDriver.FindElement(searchBar).SendKeys("www.fast.com");

            Thread.Sleep(waitTime);
            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitTime);
            webDriver.FindElement(fastLink).Click();

            Thread.Sleep(waitTime2);
            webDriver.FindElement(refresh).Click();

            Thread.Sleep(waitTime2);
            webDriver.FindElement(moreInfo).Click();
            
            var actualResult = webDriver.FindElement(resultText1);
            Assert.IsTrue(actualResult.Text.Equals("Ibadan, NG"));

            var actualResult2 = webDriver.FindElement(settings);
            Assert.IsTrue(actualResult2.Text.Equals("Settings"));

            Thread.Sleep(waitTime);
            webDriver.FindElement(settings).Click();

            Thread.Sleep(waitTime);
            webDriver.FindElement(minDur).SendKeys("5");

            Thread.Sleep(waitTime);
            webDriver.FindElement(maxDur).SendKeys("15");

            Thread.Sleep(waitTime);
            webDriver.FindElement(saveChanges).Click();



            webDriver.Quit();
        }

        
    }
}
