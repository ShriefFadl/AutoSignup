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
   public class RegisterPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@name='firstname']")]
        private IWebElement firstNameTextField;
        [FindsBy(How = How.XPath, Using = ".//input[@name='lastname']")]
        private IWebElement lastNameTextField;
        [FindsBy(How = How.XPath, Using = ".//input[@name='phone']")]
        private IWebElement phoneTextField;

        [FindsBy(How = How.XPath, Using = ".//input[@name='email']")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.XPath, Using = ".//input[@name='password']")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.XPath, Using = ".//input[@name='confirmpassword']")]
        private IWebElement confirmPasswordTextField;

        [FindsBy(How = How.XPath, Using = ".//button[contains(text(),'Sign Up')]")]
        private IWebElement registerButton;

        public void RegisterNewUser()
        {

            firstNameTextField.SendKeys("Shrief");
            lastNameTextField.SendKeys("Fadl");
            phoneTextField.SendKeys("010010001002");
            emailAddressTextField.SendKeys("admin@admin.com");
            passwordTextField.SendKeys("Password123");
            confirmPasswordTextField.SendKeys("Password123");

            registerButton.Click();
        }
    }
}
