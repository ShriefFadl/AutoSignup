using OpenQA.Selenium;
using AutoSignup.Generators;
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
            var User = UserGenerator.Generate();

            firstNameTextField.SendKeys(User.FirstName);

            lastNameTextField.SendKeys(User.LastName);
            phoneTextField.SendKeys(User.PhoneNumber);
            emailAddressTextField.SendKeys(User.EmailAddress);
            passwordTextField.SendKeys(User.Password);
            confirmPasswordTextField.SendKeys(User.Password);

            registerButton.Click();
        }
    }
}
