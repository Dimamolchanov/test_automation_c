using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using test_automation.Driver;
using test_automation.Utils;

namespace test_automation.Tests
{   [TestFixture]
    public abstract class BaseTest
    {

    [SetUp]
    public void SetUp()
        {
            string output = CommonUtils.ExecuteCMDCommand();
            DriverManager.GetWebDriverInstance(); 
        }


    [TearDown]
    public void TearDown()
        {
            DriverManager.CloseBrowser();
        }

    }

}
