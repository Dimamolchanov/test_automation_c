using NUnit.Framework;
using test_automation.Steps;
using test_automation.Utils;

namespace test_automation.Tests
{
    public class OnlinerTest : BaseTest
    {
        OnlinerSteps steps = new OnlinerSteps();

    [Test(Author = CommonConstants.DIMAS)]
    //[TestCaseSource("asas")]
    public void OpenOnlinerHomePage()
        {
            steps.OpenHomePage();
        }


    [Test(Author = CommonConstants.DIMAS)]
    //[TestCaseSource("asas")]
        public void OpenOnlinerHomePageAndClickCars()
        {
            steps.OpenHomePageAndClickCars();
        }
    }
}
