﻿using test_automation.Pages;

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

        public void OpenHomePageAndClickCars()
        {
            HomePage homePage = new HomePage();
            homePage.OpenPage();
            homePage.ClickLadaLink();
        }

        public void checkUrl() {
            HomePage hp = new HomePage();
            hp.CheckURL("https://metanit.com/sharp/tutorial/3.1.php");

        }
    }
}
