using OpenQA.Selenium;

namespace BestPracticesPOMHomework.Extensions
{
    public static class ElementExtension
    {
        public static void Type(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
