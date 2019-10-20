using OpenQA.Selenium;

namespace BestPracticesPOMHomework.Pages
{
    public partial class QAAutoPage : BasePage
    {
        public QAAutoPage(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement Header => Driver.FindElement(By.TagName("h1"));
       
    }
}
