using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public abstract class BasePage_POM
    {
        public IWebDriver driver;
        //public BasePage_POM(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        public BasePage_POM()
        {
            this.driver = DriverContext.Driver;
        }
    }
}
