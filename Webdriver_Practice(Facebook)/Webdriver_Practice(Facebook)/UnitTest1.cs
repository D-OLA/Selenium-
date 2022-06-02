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
            int waitingTime = 1300;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By facebookLink = By.XPath("/html/body/div[7]/div/div[10]/div/div[2]/div[2]/div/div/div[1]/div/div/div/div/div/div[1]/a/h3");
            By emailOrPhoneNumber = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input");
            By password = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[2]/div/input");
            By login = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button");
            By friendsList = By.ClassName("l9j0dhe7");
            
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com/");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("facebook login");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(facebookLink).Click();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(emailOrPhoneNumber).SendKeys("***********");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(password).SendKeys("*********");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(login).Click();
                
            Thread.Sleep(waitingTime);

            webDriver.FindElement(friendsList).Click();

            Thread.Sleep(waitingTime);


            //webDriver.Quit();
        }
    }
}
