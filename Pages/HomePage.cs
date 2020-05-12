using test_automation.Driver;
using test_automation.Utils;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace test_automation.Pages
{
    public class HomePage : BasePage
    {
        protected override string PageUrl => CommonConstants.ONLINER_HOST;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'lada')]")]
        private IWebElement ladaLink;

        public void ClickLadaLink()
        {
            if (ladaLink.Displayed)
            {
                ladaLink.Click();
                Thread.Sleep(10000);
            }
            else
            {
                throw new ElementNotInteractableException("Fuck Lada");
            }
        }
    }
}
