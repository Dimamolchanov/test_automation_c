using OpenQA.Selenium.Support.PageObjects;
using test_automation.Driver;

namespace test_automation.Pages
{
    abstract public class BasePage
    {
        protected abstract string PageUrl { get; }
        public BasePage() => InitPage();

        public void OpenPage() => DriverManager.GetWebDriverInstance().Navigate().GoToUrl(PageUrl);

        private void InitPage() => PageFactory.InitElements(DriverManager.GetWebDriverInstance(), this);



    }
}
