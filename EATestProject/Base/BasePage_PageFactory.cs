using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public abstract class BasePage_PageFactory: Base
    {
        //public IWebDriver driver;
        //public BasePage_PageFactory(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        
        public BasePage_PageFactory()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

       
    }
}
