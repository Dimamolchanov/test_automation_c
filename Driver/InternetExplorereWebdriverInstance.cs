using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace test_automation.Driver
{
    public class InternetExplorereWebdriverInstance : IWebDriverInstanceInit
    {
        public IWebDriver InitWebriverInstance() => new InternetExplorerDriver();
    }
}
