using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2
{
    public class LoginPage
    {
        private IWebDriver webdriver;
        public LoginEmailPage(IWebDriver driver)
        {
            webdriver = driver;
        }
        public IWebElement login => webdriver.FindElement(By.Id("login"));
        public IWebElement pass => webdriver.FindElement(By.Name("password"));
    }
}
