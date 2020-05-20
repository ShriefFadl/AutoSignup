using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignup
{
    public static class Browser
    {
        private static string baseUrl = "https://www.phptravels.net/";
        private static IWebDriver webDriver = new ChromeDriver();
        
        public static void Initialize()
        {
            Goto("");
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
