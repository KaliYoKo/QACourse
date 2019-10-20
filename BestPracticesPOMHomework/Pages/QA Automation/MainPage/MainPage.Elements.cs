using OpenQA.Selenium;

namespace BestPracticesPOMHomework.Pages
{ 
    public partial class MainPage : BasePage
{ 
    public MainPage(IWebDriver driver)
        : base(driver)
    {
    }
    public string Url = "https://softuni.bg/";
    public IWebElement Courses => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/a")); //Обучения   
    public IWebElement QA => Wait.Until<IWebElement>((w) => { return w.FindElement(By.LinkText("QA Automation - септември 2019")); }); //QA Automation 

    }


}
