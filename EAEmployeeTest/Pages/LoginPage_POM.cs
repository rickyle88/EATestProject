using EAAutoFrameWork.Base;
using EAAutoFrameWork.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class LoginPage_POM : BasePage_POM
   { 
        //private IWebDriver driver;

        //ctor + double tab for generate snippet constructor
        //public LoginPage_POM(IWebDriver driver) : base(driver)
        //{
        //    //this.driver = driver;
        //}

        //public LoginPagePOM(IWebDriver driver) : base(driver)
        //{

        //}

        By lnkLogin = By.LinkText("Login");
        By txtUsername = By.Id("UserName");
        By txtPassword = By.Id("Password");
        By btnLogin = By.XPath("//input[@value='Log in']");
     
        

        public void clickLogin1()
        {
            IWebElement webElement = driver.FindElement(lnkLogin);
            webElement.Click();
        }

        public void enterUserName(string value)
        {
            IWebElement webElement = driver.FindElement(txtUsername);
            
            webElement.SendKeys(value);
        }

        public void enterPassword(string value)
        {
            IWebElement webElement = driver.FindElement(txtPassword);
            webElement.SendKeys(value);
            
            
        }

        public void clickLoginButton2()
        {
            IWebElement webElement = driver.FindElement(btnLogin);
            webElement.Click();
        }




    }
}
