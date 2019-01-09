using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EAAutoFrameWork.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class ExtendedSteps : BaseStep
    {

        [Given(@"I have navigatged to the application")]
        public void GivenIHaveNavigatgedToTheApplication()
        {
            //h.ClickLoginLink();
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExist();
        }



        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            string user = data.UserName;
            string pass = data.Password;
            CurrentPage.As<LoginPage_PageFactory>().Login(user, pass);
        }

        [Then(@"I click (.*) link")]
        public void ThenIClickLink(string linkName)
        {
            switch (linkName)
            {
                case "login":
                    CurrentPage = CurrentPage.As<HomePage>().ClickLoginLink();
                    break;
                case "employeeList":
                    CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeListLink();
                    break;
                default:
                    break;
            }

        }

        [Then(@"I click (.*) button")]
        public void ThenIClickButton(string buttonName)
        {
            switch (buttonName)
            {
                case "Login":
                    CurrentPage = CurrentPage.As<LoginPage_PageFactory>().ClickLoginButton();
                    break;
                case "createnew":
                    CurrentPage = CurrentPage.As<EmployeeListPage>().ClickCreateNew();
                    break;
                case "create":
                    CurrentPage.As<CreateEmployeePage>().clickCreate();
                    break;
                default:
                    break;
            }

        }
    }
}
