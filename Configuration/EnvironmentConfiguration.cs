using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_automation.Utils;

namespace test_automation.Configuration
{
    public class EnvironmentConfiguration
    {
        
        public static string GetProjectConfig(string appKey) => System.Configuration.ConfigurationManager.AppSettings[appKey];

        public static BrowserType GetBrowserTypeFromConfig()
        {
            switch (GetProjectConfig(CommonConstants.BROWSER_TYPE))
            {
                case CommonConstants.BROWSER_CHROME:
                    return BrowserType.CHROME;
                case CommonConstants.BROWSER_FIREFOX:
                    return BrowserType.FIREFOX;
                case CommonConstants.BROWSER_IE:
                    return BrowserType.IEXPLORER;
                default:
                    return BrowserType.REMOTE;
            }
        }
    }
}
