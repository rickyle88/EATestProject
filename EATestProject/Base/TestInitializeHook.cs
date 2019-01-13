using EAAutoFrameWork.Config;
using EAAutoFrameWork.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public abstract class TestInitializeHook : Base
    {
        public BrowserType Brower;

        public TestInitializeHook(BrowserType browser)
        {
            this.Brower = browser;
        }

        public void InitializeSettings()
        {
            //Set all the settings for the framework
            ConfigReader.SetFrameworkSettings();

            //Set log
            LogHelpers.CreateLogFile();

            //Open browser
            OpenBrower(Brower);

            LogHelpers.Write("Opened the browser !!!");
        }

        

       

        public void OpenBrower(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = GetChromeDriver();
                    
                    DriverContext.browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    break;
            }
        }

        public IWebDriver GetChromeDriver()
        {
            //Put chromedriver.exe in main folder, when we Build solution 
            //Right click chromedriver.exe on Solution Explorer -> `Copy to Output Directory`: `Copy if newer` - When you build solution, chromedriver.exe will be copy to bin/Debug folder
            //chromedriver.exe will automatically be copied to bin/Debug folder
            //This line will point to bin/Debug folder dynamically 
            var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outputDirectory);

            //Another way is hard coded chromedriver folder 
            //var outputdirectory = Path.GetFullPath("C:\\Automation Tools\\ChromeDriver");

            //return new ChromeDriver(outputdirectory);
        }

        public virtual void NavigateSite()
        {
            string url = Settings.AUT;
            DriverContext.browser.GoToURL(url);

            LogHelpers.Write("Naviagated to the page !!!");
        }
    }
}
