using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using ConsoleApp1.POM;
using ConsoleApp1.BaseLayer;

namespace ConsoleApp1.Testing
{
    [TestFixture]
    public class Starter : BaseClass
    {

        [Test]
        [Category("Login To VTBTestBank")]
        public void MyTest1()
        {
            var LoginPage = new LoginPage(driver);
            LoginPage.PaymentUser();
        }
    }
}