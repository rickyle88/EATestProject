using EAAutoFrameWork.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Extensions
{
    public static class WebDriverExtensions
    {
        public static object ExecuteJS(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
    }
}
