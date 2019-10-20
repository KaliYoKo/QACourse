using NUnit.Framework;


namespace BestPracticesPOMHomework.Pages
{
    public partial class AuthenticationPage
    {


        public void Assert1EmptyField(string element_name)
        {

            Assert.AreEqual("There is 1 error", ErrorsCount.Text);
            Assert.AreEqual(element_name + " is required.", ErrorMessages[0].Text);
        }
        public void Assert2EmptyFields()
        {
            Assert.AreEqual("There are 2 errors", ErrorsCount.Text);
            Assert.AreEqual("lastname is required.", ErrorMessages[0].Text);
            Assert.AreEqual("firstname is required.", ErrorMessages[1].Text);
        }
    }
}
