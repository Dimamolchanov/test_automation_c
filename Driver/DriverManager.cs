using System;
using OpenQA.Selenium;
using test_automation.Configuration;
using test_automation.Utils;

namespace test_automation.Driver
{
    public class DriverManager
    {   
        private static IWebDriver driver;
        private DriverManager(){}

        public static IWebDriver GetWebDriverInstance() {
            if (driver == null) 
            {
                driver = WebDriverFactory.initWebDriverInstance(EnvironmentConfiguration.GetBrowserTypeFromConfig()).InitWebriverInstance();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToInt32(EnvironmentConfiguration.GetProjectConfig(CommonConstants.TIMEOUT_SECONDS)));
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }

    }
}
