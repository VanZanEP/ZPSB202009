using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace SpecFlowProject2
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(TypeDriver typ)
        {
            IWebDriver webdriver;
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            switch (typ)
            {
                case TypeDriver.Chrome:
                    webdriver = new ChromeDriver(path);
                    break;
                case TypeDriver.Firefox:
                    webdriver = new FirefoxDriver(path);
                    break;
                case TypeDriver.Edge:
                    webdriver = new EdgeDriver(path);
                    break;
                case TypeDriver.InternetExplorer:
                    webdriver = new InternetExplorerDriver(path);
                    break;
                case TypeDriver.Safari:
                    webdriver = new SafariDriver(path);
                    break;
                default:
                    throw new ArgumentException("Wrong driver");
            }
            return webdriver;
        }
    }

}
