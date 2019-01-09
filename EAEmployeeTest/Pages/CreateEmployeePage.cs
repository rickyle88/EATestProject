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
    public class CreateEmployeePage : BasePage_PageFactory
    {

        [FindsBy(How = How.Id, Using = "Name")]
        IWebElement txtName { get; set; }

        [FindsBy(How = How.Id, Using = "Salary")]
        IWebElement txtSalary { get; set; }

        [FindsBy(How = How.Id, Using = "DurationWorked")]
        IWebElement txtDurationWorked { get; set; }

        [FindsBy(How = How.Id, Using = "Grade")]
        IWebElement txtGrade { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        IWebElement txtEmail { get; set; }

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

        public void CreateEmployee(string name, string salary, string durationWorked, string grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(salary);
            txtDurationWorked.SendKeys(durationWorked);
            txtGrade.SendKeys(grade);
            txtEmail.SendKeys(email);
        }

        
    }
}
