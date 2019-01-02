using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using EAEmployeeTest.Pages;
using EAAutoFrameWork.Base;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "http://eaapp.somee.com/";

        //private IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            //driver = new ChromeDriver();
            //driver = GetChromeDriver();
            DriverContext.Driver = GetChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            //driver.Navigate().GoToUrl(url);

            Login();

            //driver.Close();
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
            LoginPage_POM loginPOM = new LoginPage_POM();

            //Click Login button
            loginPOM.clickLogin1();

            //Enter username
            loginPOM.enterUserName("admin");

            //Enter password
            loginPOM.enterPassword("password");

            //Click Login button 
            loginPOM.clickLoginButton2();






            ////Page Object Model - Page Factory - has been deprecated

            ////
            //LoginPage_PageFactory login = new LoginPage_PageFactory();

            ////Click Login button
            //login.lnkLogin.Click();

            ////Enter username
            //login.txtUserName.SendKeys("admin");

            ////Enter password
            //login.txtPassword.SendKeys("password");

            ////Click Login button
            //login.btnLogin.Click();
        }
    }
}
