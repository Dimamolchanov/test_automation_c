using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_automation.Configuration;


namespace test_automation.Driver
{
    public class WebDriverFactory
    {
        public static IWebDriverInstanceInit initWebDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.CHROME:
                    System.Console.WriteLine("Setting up Chrome");
                    return new ChromeWebdriverInstance();
                case BrowserType.FIREFOX:
                    System.Console.WriteLine("Setting up Firefox");
                    return new FirefoxWebdriverInstance();
                case BrowserType.IEXPLORER:
                    System.Console.WriteLine("Setting up IE");
                    return new InternetExplorereWebdriverInstance();
                case BrowserType.REMOTE:
                    //TO DO implement remote webdriver
                    throw new NotImplementedException("Remote Webdriver not implemented");
                default:
                    throw new ArgumentException("Not valid ");
            }
        }
    }
}
