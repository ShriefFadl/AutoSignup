using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using AutomatedTester.BrowserMob.HAR;
using AutomatedTester.BrowserMob;
using System.IO;

using OpenQA.Selenium.Remote;

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

        public static void ReadRegisterResponse()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "\\browsermob-proxy.bat");
            Server server = new Server(path);
            server.Start();

            Client client = server.CreateProxy();
            client.NewHar("RegistrationResponse");

            var seleniumProxy = new Proxy { HttpProxy = client.SeleniumProxy };
           
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.Proxy, seleniumProxy);


            // retrieve performance stats for
            IWebDriver driver = new ChromeDriver(capabilities);
            driver.Navigate().GoToUrl("https://www.phptravels.net/account/");

            // Get the performance stats 
            //That contains the response of the login an successful registration
            HarResult harData = client.GetHar();

           
            client.Close();
            server.Stop();


        }
    }
}
