using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AutoSignup
{
    class SignUp
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void Extendstart()
        {
            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\shrief fadl\Source\Repos\AutoSignup\AutoSignup\extent reports\Register.html");
            extent.AttachReporter(htmlreporter);


        }
        [OneTimeTearDown]
        public void Extentclose()
        {
            extent.Flush();
        }


        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C://webdrivers");

        }
        ExtentTest test = null;

        [Test]
        public void Register()
        {


        }
    }
}
