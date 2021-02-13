using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;



namespace SpecFlowProject2
{
    class SaveError
    {
        private readonly IWebDriver _driver;
        public SaveErrorDetails(IWebDriver driver)
        {        

            _driver = driver;
        }

    internal class driver
    {
    }

    public void SaveScreenshotAndLogsOnError()
        {
            
            if (TestContext.CurrentContext.Result.Outcome.Status ==
                NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                SaveLogs();
                SaveScreenshot();
            }
        }
        private void SaveLogs()
        {
            try
            {
                var logs = _driver.Manage().Logs.GetLog(LogType.Browser);
                string logsFilePath = Path.Combine("c:\\", "logs.txt");
                List<string> logsParsed = new List<string>();
                foreach (var log in logs)
                {
                    logsParsed.Add(log.ToString());
                }
                File.WriteAllLines(logsFilePath, logsParsed.ToArray(), Encoding.UTF8);
                TestContext.AddTestAttachment(logsFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving logs: {0}", ex);
            }
        }
        private void SaveScreenshot()
        {
            try
            {
                if (_driver is ITakesScreenshot takesScreenshot)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    string screenshotFilePath = Path.Combine("c:\\", "screenshot.png");
                    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                    TestContext.AddTestAttachment(screenshotFilePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
