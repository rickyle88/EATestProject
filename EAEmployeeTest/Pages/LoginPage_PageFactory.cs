using EAAutoFrameWork.Base;
using EAAutoFrameWork.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class LoginPage_PageFactory : BasePage_PageFactory
    {
        //IWebDriver driver;

        //ctor + double tab for generate snippet constructor
        //public LoginPage_PageFactory(IWebDriver driver)
        //{
        //    //this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        //public LoginPage_PageFactory(IWebDriver driver) : base(driver)
        //{
            
        //}

       

        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement lnkLogin { get; set; }

        //Navigate to Employee List page
        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        IWebElement btnLogin { get; set; }

        public void ClickLoginLink()
        {
            lnkLogin.Click();
            //lnkLogin.SelectDropDownList("Hello");
        }

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }

        //Page Navigation: ensure that the business logic is embedded in our code
        public EmployeePage ClickEmployeeListLink()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeePage>();
            
        }

        //Check if Username and password text box are displayed
        public void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }


    }
}
