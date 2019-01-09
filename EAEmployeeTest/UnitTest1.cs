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
using EAAutoFrameWork.Config;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1: HookInitialize
    {

        //string url = "http://eaapp.somee.com/";
        //Get URL from GlobalConfig.xml




        //string url = Settings.AUT;

        //private IWebDriver driver;



        //[TestMethod]
        //public void TestMethod1()
        //{
            

        //    //Read excel file
        //    string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Data.xlsx";
        //    ExcelHelpers.PopulateInCollection(fileName);
           


        //    ////Page Object Model - Page Factory - has been deprecated
        //    CurrentPage = GetInstance<LoginPage_PageFactory>();

        //    CurrentPage.As<LoginPage_PageFactory>().ClickLoginLink();

        //    //Check if Username and Password textbox are present
        //    CurrentPage.As<LoginPage_PageFactory>().CheckIfLoginExist();

        //    //CurrentPage.As<LoginPage_PageFactory>().Login("admin", "password");
        //    //Get username and password from Excel file
        //    string userName = ExcelHelpers.ReadData(1, "UserName");
        //    string password = ExcelHelpers.ReadData(1, "Password");
        //    CurrentPage.As<LoginPage_PageFactory>().Login(userName, password);

        //    CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeListLink();

        //    CurrentPage = CurrentPage.As<EmployeeListPage>().ClickCreateNew();

            

        //    CurrentPage.As<CreateEmployeePage>().enterName("Name");
        //    CurrentPage.As<CreateEmployeePage>().clickCreate();






        //    //driver.Close();
        //}

        //[TestMethod]
        //public void TableOperation()
        //{

           

        //    //Read excel file
        //    string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Data.xlsx";
        //    ExcelHelpers.PopulateInCollection(fileName);

        //    LogHelpers.Write("Naviagated to the page !!!");



        //    ////Page Object Model - Page Factory - has been deprecated
        //    CurrentPage = GetInstance<LoginPage_PageFactory>();

        //    CurrentPage.As<LoginPage_PageFactory>().ClickLoginLink();


        //    //CurrentPage.As<LoginPage_PageFactory>().Login("admin", "password");
        //    //Get username and password from Excel file
        //    string userName = ExcelHelpers.ReadData(1, "UserName");
        //    string password = ExcelHelpers.ReadData(1, "Password");
        //    CurrentPage.As<LoginPage_PageFactory>().Login(userName, password);

        //    CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeListLink();

        //    //Testing HTML Table Helpers
        //    //var employeeTable = CurrentPage.As<EmployeePage>().GetEmployeeList();
        //    //HtmlTableHelpers.ReadTable(employeeTable);

        //    //column index,  Ref Column Name - ex: First column name , Ref Column value - ex: Ramesh, 
        //    //HtmlTableHelpers.PerformActionOnCell("6", "Name", "Ramesh", "Edit");

        //}

       

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
