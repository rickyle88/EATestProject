using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using EAEmployeeTest.Pages;
using EAAutoFrameWork.Base;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using EAAutoFrameWork.Helpers;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1:Base
    {

        string url = "http://eaapp.somee.com/";

        //private IWebDriver driver;

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
                    DriverContext.Driver = GetChromeDriver(); ;
                    DriverContext.browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //driver = new ChromeDriver();
            //driver = GetChromeDriver();
            //DriverContext.Driver = GetChromeDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);

            //Read excel file
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Data.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrower(BrowserType.Chrome);

            LogHelpers.Write("Opened the browser !!!");

            DriverContext.browser.GoToURL(url);

            LogHelpers.Write("Naviagated to the page !!!");

           


            ////Page Object Model - Page Factory - has been deprecated
            CurrentPage = GetInstance<LoginPage_PageFactory>();

            CurrentPage.As<LoginPage_PageFactory>().ClickLoginLink();


            //CurrentPage.As<LoginPage_PageFactory>().Login("admin", "password");
            //Get username and password from Excel file
            string userName = ExcelHelpers.ReadData(1, "UserName");
            string password = ExcelHelpers.ReadData(1, "Password");
            CurrentPage.As<LoginPage_PageFactory>().Login(userName, password);

            CurrentPage = CurrentPage.As<LoginPage_PageFactory>().ClickEmployeeListLink();

            CurrentPage = CurrentPage.As<EmployeePage>().ClickCreateNew();

            

            CurrentPage.As<CreateEmployeePage>().enterName("Name");
            CurrentPage.As<CreateEmployeePage>().clickCreate();






            //driver.Close();
        }

        [TestMethod]
        public void TableOperation()
        {
            //Read excel file
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Data.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrower(BrowserType.Chrome);

            LogHelpers.Write("Opened the browser !!!");

            DriverContext.browser.GoToURL(url);

            LogHelpers.Write("Naviagated to the page !!!");




            ////Page Object Model - Page Factory - has been deprecated
            CurrentPage = GetInstance<LoginPage_PageFactory>();

            CurrentPage.As<LoginPage_PageFactory>().ClickLoginLink();


            //CurrentPage.As<LoginPage_PageFactory>().Login("admin", "password");
            //Get username and password from Excel file
            string userName = ExcelHelpers.ReadData(1, "UserName");
            string password = ExcelHelpers.ReadData(1, "Password");
            CurrentPage.As<LoginPage_PageFactory>().Login(userName, password);

            CurrentPage = CurrentPage.As<LoginPage_PageFactory>().ClickEmployeeListLink();

            //Testing HTML Table Helpers
            //var employeeTable = CurrentPage.As<EmployeePage>().GetEmployeeList();
            //HtmlTableHelpers.ReadTable(employeeTable);

            //column index,  Ref Column Name - ex: First column name , Ref Column value - ex: Ramesh, 
            //HtmlTableHelpers.PerformActionOnCell("6", "Name", "Ramesh", "Edit");

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

        public void Login()
        {
            //LoginPage_POM loginPOM = new LoginPage_POM();

            ////Click Login button
            //loginPOM.clickLogin1();

            ////Enter username
            //loginPOM.enterUserName("admin");

            ////Enter password
            //loginPOM.enterPassword("password");

            ////Click Login button 
            //loginPOM.clickLoginButton2();






           







        }
    }
}
