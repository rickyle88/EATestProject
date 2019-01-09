using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public static class DriverContext
    {
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
                //Implicit wait: the implicit wait is set for the life of the WebDriver object instance.
                //driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            }
        }

        public static Browser browser { get; set; }
    }
}
