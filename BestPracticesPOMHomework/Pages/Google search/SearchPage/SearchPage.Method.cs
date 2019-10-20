using OpenQA.Selenium;
using BestPracticesPOMHomework.Extensions;

namespace BestPracticesPOMHomework.Pages
{
    public partial class SearchPage
    {
        public void SearchByInput(string input)
        {
            ElementExtension.Type(SearchField, input);
            SearchField.SendKeys(Keys.Enter);
        }
    }
}
