using OpenQA.Selenium;

namespace BestPracticesPOMHomework.Pages
{
    public partial class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) 
            :base(driver)
        {
        }
        public string Url => "https://www.google.com/";
        public IWebElement SearchField => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

      
    }
}
