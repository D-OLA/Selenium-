﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            By myProfile = By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[1]/div/div/div[1]/div/div/div[1]/ul/li/div/a/div[1]/div[2]/div/div/div/div/span/span");
            By allFriends = By.ClassName("d2edcug0 hpfvmrgz qv66sw1b c1et5uql lr9zc1uh a8c37x1j fe6kdd0r mau55g9w c8b282yb keod5gw0 nxhoafnm aigsh9s9 d3f4x2em iv3no6db jq4qci2q a3bd9o3v lrazzd5p m9osqain");

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

            webDriver.FindElement(emailOrPhoneNumber).SendKeys("08138924429");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(password).SendKeys("#Laitan99.");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(login).Click();
                
            Thread.Sleep(waitingTime);

            webDriver.FindElement(myProfile).Click();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(allFriends).Click();

            Thread.Sleep(waitingTime);


            //webDriver.Quit();
        }
    }
}
