using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Drawing;
using AutoSignup.Pages;
using System.IO;

namespace AutoSignup 
{
    

    [TestFixture]
	public class CaseTests 
	{
       
        ExtentReports extent = null;
		 
		 [OneTimeSetUp]
		public void Extendstart()
		{
			extent = new ExtentReports();
			var htmlreporter = new ExtentHtmlReporter(@"..\..\Pages\extent reports\Register Report.html");
			extent.AttachReporter(htmlreporter);


		}
		[OneTimeTearDown]
		public void Extentclose()
		{
			extent.Flush();
		}

       
		ExtentTest test = null;

	   [Test]
		public void CanRegister()
		{
			try
			{
				test = extent.CreateTest("Registratiion").Info("test started");
                
                //open chrome
                Browser.Goto("register");
                test.Log(Status.Info, "chrome lanched");
                
                //start to register
                pages.Register.RegisterNewUser();
                test.Log(Status.Info, "data entered");
                
                //passed test
                test.Log(Status.Pass, "Test passed");
                Assert.Pass("registration completed");
               
                
                
                //take screen shoot
                Screenshot Sshot = ((ITakesScreenshot)Browser.Driver).GetScreenshot();
                Sshot.SaveAsFile(@"..\..\Pages\extent reports\registration passed.Jpeg", ScreenshotImageFormat.Jpeg);

            }

			catch (Exception e)
			{
				test.Log(Status.Fail,e.ToString());
               // Assert.Fail("registrtion not completed");
				throw;
			}
			finally
			{
				Browser.Close();
			}
		}


        [Test]
        public void CanLogin()
        {
            try
            {
                Browser.Goto("login");
                pages.Login.LogIn();
                Assert.Pass("loged in");

                Browser.ReadRegisterResponse();
                
            }
            catch (Exception)
            {


                throw;
            }

            finally
            {
                Browser.Close();
            }
            



        }
	}
	
	   


	

   
		   
		
		

	}

