using EAAutoFrameWork.Base;
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
        public IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        public IWebElement btnLogin { get; set; }
    }
}
