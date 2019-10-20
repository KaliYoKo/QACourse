using NUnit.Framework;
using BestPracticesPOMHomework.Pages;
using BestPracticesPOMHomework.Tests;

namespace BestPracticesPOMHomework
{
    [TestFixture]
    public class QAAutoPOM : BaseTest
    {
        private MainPage _mainPage;
        private QAAutoPage _qaAutoPage;
        [SetUp]
       
        public void Init()
        {
            _mainPage = new MainPage(Driver);
            _qaAutoPage = new QAAutoPage(Driver);
        }
        [Test]
        public void CheckPageTitle()
        {
            _mainPage.Navigate(_mainPage.Url);
            _mainPage.FindQACourse();
            _qaAutoPage.CheckHeaderText("QA Automation - септември 2019");
        }
     /*   [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }  */
    }
}

    

