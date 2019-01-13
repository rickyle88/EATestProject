using EAAutoFrameWork.Base;
using EAAutoFrameWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAEmployeeTest.Hook
{
    [Binding]
    public class HookInitialize: TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
            InitializeSettings();
            //NavigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterFeature]
        public static void QuitBroswer()
        {
            //TestInitializeHook.
            DriverContext.DriverClose();
            LogHelpers.CloseFile();
        }



    }
}
