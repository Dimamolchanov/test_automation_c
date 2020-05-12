using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace test_automation.Driver
{
    public class FirefoxWebdriverInstance : IWebDriverInstanceInit
    {
        public IWebDriver InitWebriverInstance() => new FirefoxDriver();
    }
}
