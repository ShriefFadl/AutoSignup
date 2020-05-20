using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SeleniumExtras.PageObjects;

namespace AutoSignup.Pages
{
   public class LoginPage
    {

        [FindsBy(How = How.XPath, Using = ".//input[@type='email']")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.XPath, Using = ".//input[@type='password']")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='loginfrm']/button")]
        private IWebElement logInButton;

        public void LogIn()
        {
            emailAddressTextField.SendKeys("admin@admin.com");
            passwordTextField.SendKeys("Password");

            logInButton.Click();
        }
    }
}
