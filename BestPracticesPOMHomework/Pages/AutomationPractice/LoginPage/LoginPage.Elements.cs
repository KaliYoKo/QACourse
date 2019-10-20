using OpenQA.Selenium;
using System;


namespace BestPracticesPOMHomework.Pages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php";
        public IWebElement SighInButton => Driver.FindElement(By.ClassName("login"));
        public string UrlDirect => "http://automationpractice.com/index.php?controller=my-account";

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));
        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
