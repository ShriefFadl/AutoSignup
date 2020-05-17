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

	[TestFixture]
	public class Login
	{
		ExtentReports extent = null;
		 
		 [OneTimeSetUp]
		public void Extendstart()
		{
			extent = new ExtentReports();
			var htmlreporter = new ExtentHtmlReporter(@"C:\Users\shrief fadl\Source\Repos\AutoSignup\AutoSignup\extent reports\Login.html");
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
		public void open_chrome()
		{
			try
			{
				test = extent.CreateTest("startBrowser").Info("test started");

				driver.Url = "https://www.phptravels.net/login";
				driver.Manage().Window.Maximize();
				test.Log(Status.Info, "chrome lanched");

				IWebElement EmailTextbox = driver.FindElement(By.XPath(".//*[@id='loginfrm']/div[3]/div[1]/label/input"));
				IWebElement PasswordTextbox = driver.FindElement(By.XPath(".//*[@id='loginfrm']/div[3]/div[2]/label/input"));
				IWebElement LoginBut = driver.FindElement(By.XPath(".//*[@id='loginfrm']/button"));
				EmailTextbox.SendKeys("shrief_fadl@outlook.com");
				PasswordTextbox.SendKeys("XFGASFAF");
				test.Log(Status.Info, "data entered");

				LoginBut.Click();
                Screenshot Sshot = ((ITakesScreenshot)driver).GetScreenshot();
                Sshot.SaveAsFile("log in passed", ScreenshotImageFormat.Png);
				test.Log(Status.Pass, "Test passed");

			}
			catch (Exception e)
			{
				test.Log(Status.Fail,e.ToString());
				throw;
			}
			finally
			{
				driver.Quit();
			}
		}

	}
	
	   


	

   
		   /*
		[TearDown]
		public void closeBrowser()
		{
			driver.Close();
		}
		*/

	}

