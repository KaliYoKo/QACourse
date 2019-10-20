using NUnit.Framework;
using BestPracticesPOMHomework.Pages;
using BestPracticesPOMHomework.Tests;

namespace BestPracticesPOMHomework
{
    [TestFixture]
    public class GoogleSearchPOM : BaseTest
    {
        private SearchPage _searchPage;
        private ResultPage _resultPage;
        

        [SetUp]
        public void Init()
            {
            _searchPage = new SearchPage(Driver);
            _resultPage = new ResultPage(Driver);   
        }     
        [Test]
        public void CheckFirstResultPageAddressAndTitle()
        {
            _searchPage.Navigate(_searchPage.Url);
            _searchPage.SearchByInput("Selenium");
            _resultPage.VisitFirstResultPage("https://www.seleniumhq.org/", "Selenium - Web Browser Automation");  
        }      
  /*      [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        } */
    }
}
