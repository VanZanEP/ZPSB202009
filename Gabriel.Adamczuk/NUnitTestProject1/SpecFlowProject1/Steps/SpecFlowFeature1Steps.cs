using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTests.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver webdriver;
        private WebDriverWait webdriverWait;
        public SpecFlowFeature1Steps(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webdriver = driver;
            webdriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        [Given(@"I enter wp\.pl")]
        public void GivenIEnterWp_Pl()
        {
            webdriver.Navigate().GoToUrl("http://www.wp.pl");
            //wait for load
            Thread.Sleep(5000);
            var popup = "/ html / body / div[2] / div / div[2] / div[3] / div / button[2]";
            var element = webdriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(popup)));
            // bad practice
            Thread.Sleep(5000);
            element.Click();
        }

        [Given(@"I click on (.*)")]
        public void GivenIClickOn(string p0)
        {
            // bad practice
            Thread.Sleep(5000);
            var firstXPath = "/html/body/div[2]/div[5]/div[2]/div[3]/a[1]";
            var elementPoczta = webdriver.FindElement(By.XPath(firstXPath));
            elementPoczta.Click();
        }

        [When(@"I fill wrong email login")]
        public void WhenIFillWrongEmailLogin()
        {
            var login = webdriver.FindElement(By.Id("login"));
            login.SendKeys("Test");
        }

        [When(@"I fill wrong password")]
        public void WhenIFillWrongPassword()
        {
            var pass = webdriver.FindElement(By.Name("password"));
            pass.SendKeys("pomidor");
        }

        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            var submitBtnCssSelector = "#loginForm > div.notificationWrapper > button";
            var submitBtn = webdriver.FindElement(By.CssSelector(submitBtnCssSelector));
            Thread.Sleep(5000);
            submitBtn.Click();
            Thread.Sleep(5000);
        }

        [Then(@"I expect to see message as „Niestety podany login lub hasło jest błędne\.”")]
        public void ThenIExpectToSeeMessageAsNiestetyPodanyLoginLubHasloJestBledne_()
        {
            string pathToMesseage = "#formError > span:nth-child(1)";
            string didItFail = webdriver.FindElement(By.CssSelector(pathToMesseage)).Text;
            Assert.AreEqual(didItFail, "Podany login i/lub hasło są złe.");
        }
    }
}
