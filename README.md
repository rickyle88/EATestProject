# EATestProject

Automation Framework using Selenium with C# and Specflow 

Feature files:
```
EATestProject/EAEmployeeTest/Features/
```

Notice: PageFactory has been deprecated and refactoring process is still going on 

Old method: PageFactory - And we need to install https://github.com/DotNetSeleniumTools/DotNetSeleniumExtras and include this like in Page Object: using SeleniumExtras.PageObjects; 
```
 [FindsBy(How = How.LinkText, Using = "Login")]
 IWebElement lnkLogin { get; set; }
 
 public void ClickLoginLink()
{
    lnkLogin.Click();

}
```
New method: Page Object Model 
```
By lnkLogin = By.LinkText("Login");
public void clickLogin1()
{
    IWebElement webElement = driver.FindElement(lnkLogin);
    webElement.Click();
}
```
