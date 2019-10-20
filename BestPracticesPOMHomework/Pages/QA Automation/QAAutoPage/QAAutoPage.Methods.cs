using NUnit.Framework;

namespace BestPracticesPOMHomework.Pages
{
    public partial class QAAutoPage
    {
        public void CheckHeaderText(string text)
        {
            Assert.AreEqual(text, Header.Text);
        }
    }
}
