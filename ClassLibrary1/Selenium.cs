﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:45144/Selenium");
            driver.FindElement(By.Name("gender")).Click();
            driver.FindElement(By.Name("gender")).Clear();
            driver.FindElement(By.Name("gender")).SendKeys("male");
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("18");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("25");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("gender")).Click();
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("50");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("36");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("gender")).Clear();
            driver.FindElement(By.Name("gender")).SendKeys("female");
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("18");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("27");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("45");
            driver.FindElement(By.Name("calculate")).Click();
            driver.FindElement(By.Name("age")).Click();
            driver.FindElement(By.Name("age")).Clear();
            driver.FindElement(By.Name("age")).SendKeys("103");
            driver.FindElement(By.Name("calculate")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}

