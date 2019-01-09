using EAAutoFrameWork.Base;
using EAEmployeeTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {

        //HomePage h;

       

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            if (CurrentPage.As<HomePage>().GetLoggedUser().Contains("admin"))
            {
                Console.WriteLine("Successfully Login");
            }else
            {
                Console.WriteLine("UnSuccessfully Login");
            }
        }

    }
}
