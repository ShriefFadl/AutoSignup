using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSignup.Pages;
using SeleniumExtras.PageObjects;

namespace AutoSignup
{
    public class pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }
        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }
    }
}
