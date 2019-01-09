using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAAutoFrameWork.Base
{
    public class Base
    {
        //To share data between Steps => using Scenario Context in Specflow

        public BasePage_PageFactory CurrentPage
        {
            //currentPage is the key value
            get
            {
                return (BasePage_PageFactory)ScenarioContext.Current["currentPage"];
            }
            set
            {
                ScenarioContext.Current["currentPage"] = value;
            }
        }

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
