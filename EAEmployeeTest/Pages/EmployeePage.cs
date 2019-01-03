using EAAutoFrameWork.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class EmployeePage : BasePage_PageFactory
    {
        //private IWebDriver driver;

        //public EmployeePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public EmployeePage(IWebDriver driver) : base(driver)
        //{

        //}

        [FindsBy(How = How.Name, Using = "searchTerm")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create New")]
        public IWebElement lnkCreateNew { get; set; }


        //Page Navigation: ensure that the business logic is embedded in our code
        //Click Create New link => should return CreateEmployeePage
        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }






    }
}
