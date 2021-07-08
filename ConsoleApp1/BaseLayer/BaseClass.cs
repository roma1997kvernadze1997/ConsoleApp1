using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.BaseLayer
{
    public class BaseClass
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testibank.vtb.ge/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
