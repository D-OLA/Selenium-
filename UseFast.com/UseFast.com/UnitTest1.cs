﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UseFastDotCom
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFast()
        {
            int waitingTime = 1500;
            By searchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime); 
            webDriver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(searchBar).SendKeys("www.fast.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(googleSearchButton).Click();
            
        }
    }
}
