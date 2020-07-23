using test_automation.Driver;
using test_automation.Utils;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace test_automation.Pages
{
    public class HomePage : BasePage
    {
        protected override string PageUrl => CommonConstants.ONLINER_HOST;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'lada')]")]
        private IWebElement ladaLink;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'tiles')]//a[contains(@href, 'cars')]")]
        private IWebElement carsIcon;

        public void CheckURL(string url)
        {
            DriverManager.GetWebDriverInstance().Url = url;
            Thread.Sleep(10000);

        }

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

        public void ClickCarsIcon()
        {
            if (carsIcon.Displayed)
            {
                carsIcon.Click();
            }
            else
            {
                throw new ElementNotInteractableException("Fuck Lada");
            }
        }
    }
}
