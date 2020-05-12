using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_automation.Driver
{
    public interface IWebDriverInstanceInit
    {
         IWebDriver InitWebriverInstance();
    }
}
