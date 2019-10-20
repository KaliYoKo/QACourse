using OpenQA.Selenium;
using System.Collections.Generic;

namespace BestPracticesPOMHomework.Pages
{
    public partial class AuthenticationPage : BasePage
    {
        public AuthenticationPage(IWebDriver driver)
        : base(driver)
        {

        }
        public IWebElement ErrorsCount => Driver.FindElement(By.XPath("//*[@id='center_column']/div/p"));

        public IList<IWebElement> ErrorMessages => Driver.FindElements(By.XPath("//*[@id='center_column']/div/ol/li"));

    }



}

