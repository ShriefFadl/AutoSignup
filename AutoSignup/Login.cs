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
    class Login
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C://webdrivers");
        }

        [Test]
        public void open_chrome()
        {
            driver.Url = "https://www.phptravels.net/login";
            driver.Manage().Window.Maximize();
            IWebElement EmailTextbox = driver.FindElement(By.XPath(".//*[@id='loginfrm']/div[3]/div[1]/label/input"));
            IWebElement PasswordTextbox = driver.FindElement(By.XPath(".//*[@id='loginfrm']/div[3]/div[2]/label/input"));
            IWebElement LoginBut = driver.FindElement(By.XPath(".//*[@id='loginfrm']/button"));
            EmailTextbox.SendKeys("shrief_fadl@outlook.com");
            PasswordTextbox.SendKeys("XFGASFAF");
            LoginBut.Click();

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
