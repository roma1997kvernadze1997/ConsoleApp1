using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.POM
{
    class OverviewPage : BasePOM
    {
        public OverviewPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public OverviewPage()
        {

        }

        public void BackButtonTest()
        {
            
        }


        public IWebElement AvatarIcon23 => driver.FindElement(By.Id("header-avatar"));
        public IWebDriver Profile => (IWebDriver)driver.FindElement(By.XPath(""));
        public IWebDriver Security => (IWebDriver)driver.FindElement(By.XPath(""));
        public IWebDriver BackButton => (IWebDriver)driver.FindElement(By.XPath(""));
    }
}
