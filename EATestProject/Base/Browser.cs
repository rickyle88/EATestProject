using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public class Browser
    {
        private IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BrowserType Type { get; set; }

        public void GoToURL(string url)
        {
            DriverContext.Driver.Url = url;
        }

        
    }

    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}
