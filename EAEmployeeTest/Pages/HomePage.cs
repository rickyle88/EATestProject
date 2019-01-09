using EAAutoFrameWork.Base;
using EAAutoFrameWork.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    public class HomePage : BasePage_PageFactory
    {

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

        [FindsBy(How = How.XPath, Using = "//a[@title='Manage']")]
        IWebElement lnkLoggedInUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log off']")]
        IWebElement lnkLogoff { get; set; }

        public LoginPage_PageFactory ClickLoginLink()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage_PageFactory>();
            //lnkLogin.SelectDropDownList("Hello");
        }

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }

        //Page Navigation: ensure that the business logic is embedded in our code
        public EmployeeListPage ClickEmployeeListLink()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();

        }

        //Check if Username and password text box are displayed
        public void CheckIfLoginExist()
        {
            lnkLogin.AssertElementPresent();
        }

        public string GetLoggedUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }

        
       
    }
}
