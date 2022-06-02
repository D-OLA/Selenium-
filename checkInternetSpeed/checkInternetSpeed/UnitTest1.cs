﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            int waitingTime = 1500;
            By searchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By fastLink = By.XPath("/html[1]/body[1]/div[7]/div[1]/div[10]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/h3[1]");

            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://google.com");

            Thread.Sleep(waitingTime);
            webDriver.FindElement(searchBar).SendKeys("www.fast.com");

            Thread.Sleep(waitingTime);
            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);
            webDriver.FindElement(fastLink).Click();
            Thread.Sleep(waitingTime);
            Thread.Sleep(waitingTime);

            webDriver.Quit();
        }
    }
}
