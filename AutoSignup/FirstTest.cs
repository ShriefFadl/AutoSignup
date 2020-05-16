
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignup
{
    class FirstTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C://webdrivers");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.phptravels.net/login";
        } 
        /*
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        */

    }
}