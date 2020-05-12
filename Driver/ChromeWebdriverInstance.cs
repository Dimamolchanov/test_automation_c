using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test_automation.Driver
{
    public class ChromeWebdriverInstance : IWebDriverInstanceInit
    {
        public IWebDriver InitWebriverInstance() => new ChromeDriver();
    }
}
