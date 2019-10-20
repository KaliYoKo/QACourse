using BestPracticesPOMHomework.Extensions;
namespace BestPracticesPOMHomework.Pages
{
    public partial class RegistrationPage
    {
        
        public void FillForm(UserRegistration user)
        {
            RadioButtons[(int)Gender.Female].Click();
            ElementExtension.Type(CustomerFirstName, user.FirstName);
            ElementExtension.Type(CustomerLastName, user.LastName);
            ElementExtension.Type(Password, user.Password);
            Days.SelectByValue(user.Date);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            ElementExtension.Type(FirstName, user.PostFirstName);
            ElementExtension.Type(LastName, user.PostLastName);
            ElementExtension.Type(Address, user.Address);
            ElementExtension.Type(City, user.City);
            State.SelectByText(user.State);
            ElementExtension.Type(PostCode, user.PostCode);
            ElementExtension.Type(Phone, user.Phone);
            ElementExtension.Type(Alias,user.Alias);
            RegisterButton.Click();
        }
    }
}

