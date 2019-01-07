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
    class CreateEmployeePage : BasePage_PageFactory
    {

        [FindsBy(How = How.Id, Using = "Name")]
        IWebElement txtName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Create']")]
        IWebElement btnCreate { get; set; }

        public void enterName(string value)
        {
            txtName.SendKeys(value);
        }

        public void clickCreate()
        {
            btnCreate.Click();
        }
    }
}
