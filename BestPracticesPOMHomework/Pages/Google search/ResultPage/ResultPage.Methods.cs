using NUnit.Framework;

namespace BestPracticesPOMHomework.Pages
{
    public partial class ResultPage
    {
        public void VisitFirstResultPage(string pageUrl, string pageTitle)
        {
            firstResult.Click();
            var currentUrl = Driver.Url.ToString();
            var currentTitle = Driver.Title.ToString();
            Assert.AreEqual(pageUrl, currentUrl);
            Assert.AreEqual(pageTitle, currentTitle);
        }
    }
}
