using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public class Base
    {
        public BasePage_PageFactory CurrentPage { get; set; }

        private IWebDriver driver { get; set; }

        //Page Navigation using C# Generic
        protected TPage GetInstance<TPage>() where TPage : BasePage_PageFactory, new()
        {
            TPage pageInstance = new TPage()
            {
                driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage_PageFactory
        {
            return (TPage)this;

        }
    }
}
