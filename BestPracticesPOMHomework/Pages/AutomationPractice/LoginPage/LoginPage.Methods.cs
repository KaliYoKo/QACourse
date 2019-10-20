using BestPracticesPOMHomework.Extensions;

namespace BestPracticesPOMHomework.Pages
{
    public partial class LoginPage
    {
        public void SignInAndLogin(UserRegistration user)
        {
            Navigate(Url);
            SighInButton.Click();
            ElementExtension.Type(Email,user.Email);
            Submit.Click();
        }

        public void DirectLogin(UserRegistration user)
        {
            Navigate(UrlDirect);
            ElementExtension.Type(Email, user.Email);
            Submit.Click();
        }
    }
}
