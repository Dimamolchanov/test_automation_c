using test_automation.Pages;

namespace test_automation.Steps
{
    public class OnlinerSteps
    {
        public void OpenHomePage()
        {
            HomePage homePage = new HomePage();
            homePage.OpenPage();
            homePage.ClickLadaLink();
        }
    }
}
