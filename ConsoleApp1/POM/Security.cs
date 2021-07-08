using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.POM
{
    class Security : BasePOM
    {
        public Security(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public Security()
        {
        }

        public void doThis()
        {

        }

        //public IWebDriver SameProblem => driver.FindElement(By.XPath("//*[@id='login-form-username']"));

    }
}
