using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BestPracticesPOMHomework.Pages;
using System;
using BestPracticesPOMHomework.Tests;
using System.IO;
using NUnit.Framework.Interfaces;


namespace BestPracticesPOMHomework
{
    [TestFixture]
    public class AutomationPracticePOM : BaseTest
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private UserRegistration _user;
        //private ChromeDriver _driver;
        private AuthenticationPage _authPage;
        private WebDriverWait _wait;

        [SetUp]
        public void Init()
        {

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);
            _authPage = new AuthenticationPage(Driver);
            _user = UserFactory.CreateValidUser();
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));          
        }
        [Test]
        public void IsRegistrationPageIsOpened()
        {
            _loginPage.SignInAndLogin(_user);     
            _wait.Until((d) => { return d.Url == "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"; });
            Assert.AreEqual("CREATE AN ACCOUNT", _regPage.RegistrationFormH1.Text);
        }

        [Test, Description("Empty 'First name' field")]
        public void EmptyFirstName()
        {
            
            _user.FirstName = "";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            _authPage.Assert1EmptyField("firstname");
        }
        [Test, Description("Clear 'Email' field")]
        public void EmptyEmail()
        {
            _loginPage.DirectLogin(_user);
            _wait.Until((d) => { return d.Url == "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"; });
            _regPage.Email.Clear();
            _regPage.FillForm(_user);
            _authPage.Assert1EmptyField("email");
        }
        [Test, Description("Empty 'Password' field")]
        public void EmptyPassword()
        {
            _user.Password = "";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            _authPage.Assert1EmptyField("passwd");
        }

        [Test, Description("Incorrect 'Zip/Postal Code' value")]
        public void IncorrectPostCode()
        {
            _user.PostCode = "ABCD";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            var errorMessage = Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li"));
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", errorMessage.Text);
        }

        //Нарочно е подаден address вместо address1, за да fail-не теста и да направи screenshot
        [Test, Description("Empty 'Address' field, wrong element name")]  
        public void EmptyAddressMustFail()
        {
            _user.Address = "";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            _authPage.Assert1EmptyField("address");
        }
        [Test, Description("Empty 'Address' field")]
        public void EmptyAddress()
        {
            _user.Address = "";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            _authPage.Assert1EmptyField("address1");
        }
        //Yes, I know that 3 asserts are bad practice, but I think that the errors' number is good to check too :)
        [Test, Description("Empty 'First name' and 'Last name' fields")]
        public void EmptyFirstAndLastName()
        {
            _user.FirstName = "";
            _user.LastName = "";
            _loginPage.DirectLogin(_user);
            _regPage.FillForm(_user);
            _authPage.Assert2EmptyFields();
        }
        [TearDown]
        public void CleanUp()
        {
            var name = TestContext.CurrentContext.Test.Name;
            var result = TestContext.CurrentContext.Result.Outcome;

            if (result != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var directory = Directory.GetCurrentDirectory();
                var fullPath = Path.GetFullPath("..//..//..//ScreenShots//" + $"{name}.png");
                screenshot.SaveAsFile(fullPath , ScreenshotImageFormat.Png);
            }
        }
    }
}

