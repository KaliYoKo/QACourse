using OpenQA.Selenium;

namespace BestPracticesPOMHomework.Pages
{
    public partial class ResultPage : BasePage
    {
        public ResultPage(IWebDriver driver)
            : base(driver)
        {
        }

       public IWebElement firstResult => Wait.Until<IWebElement>((w) => { return w.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div[1]/a[1]/div/cite")); });        
    }
}

