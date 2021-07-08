using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ConsoleApp1.POM
{
    class BasePOM
    {
        public IWebDriver driver;

        public BasePOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        public BasePOM()
        {

        }





        //საერთო XPath
        //public IWebDriver AvatarIcon => driver.FindElement(By.Id("header-avatar"));
    }
}
