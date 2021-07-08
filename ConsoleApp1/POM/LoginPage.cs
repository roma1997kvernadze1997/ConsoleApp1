using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.POM
{
     class LoginPage : BasePOM
     {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public LoginPage()
        {
        }

        public void PaymentUser()
        {
            //Console.Write("Hello");
            ENGButton.Click();
            EnterUsername.SendKeys("Test_15");
            EnterPassword.SendKeys("Password12.");
            LoginButton.Click();
            Thread.Sleep(5000);
            EnterOTPCode();
            Thread.Sleep(8000);
        }

        public void EnterOTPCode()
        {
            EnterOTP1.SendKeys("1");
            EnterOTP2.SendKeys("1");
            EnterOTP3.SendKeys("1");
            EnterOTP4.SendKeys("1");
            SubmitButton.Click();
        }


        public IWebElement EnterUsername => driver.FindElement(By.XPath("//*[@id='login-form-username']"));
        public IWebElement EnterPassword => driver.FindElement(By.XPath("//*[@id='login-form-password']"));
        public IWebElement ENGButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/div/div/div[2]/div/div[3]/div/div/div/div"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div[3]/div/div/div/div[2]/form/div[4]/div/div/div/div"));
        
        //OTP Code XPaths
        public IWebElement EnterOTP1 => driver.FindElement(By.XPath("//*[@id='i0']"));        
        public IWebElement EnterOTP2 => driver.FindElement(By.XPath("//*[@id='i1']"));        
        public IWebElement EnterOTP3 => driver.FindElement(By.XPath("//*[@id='i2']"));
        public IWebElement EnterOTP4 => driver.FindElement(By.XPath("//*[@id='i3']"));
        public IWebElement SubmitButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div[3]/div/div/div/form/div[4]/div/div/div"));


        //IWebElement ClickENGButton = driver.FindElement(By.XPath("//div/*[contains(text(), 'Eng')]"));
        //IWebElement Password = driver.FindElement(By.Id("login-form-password"));
    }
}
