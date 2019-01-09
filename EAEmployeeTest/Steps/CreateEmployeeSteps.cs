using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using EAAutoFrameWork.Base;
using EAEmployeeTest.Pages;
namespace EAEmployeeTest.Steps
{
    [Binding]
    public class CreateEmployeeSteps : BaseStep
    {
        [Then(@"I enter following details")]
        public void ThenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            //string name = data.Name;
            //string salary = Convert.ToString(data.Salary);
            //string durationWorked = Convert.ToString(data.DurationWorked);
            //string grade = Convert.ToString(data.Grade);
            //string email = data.Email;
            //CurrentPage.As<CreateEmployeeSteps>().CreateEmployee
            //CurrentPage.As<CreateEmployeePage>().CreateEmployee(name, salary, durationWorked, grade, email);
            CurrentPage.As<CreateEmployeePage>().CreateEmployee(data.Name, data.Salary.ToString(), data.DurationWorked.ToString(), data.Grade.ToString(), data.Email);

        }

    }
}
