using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace BestPracticesPOMHomework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ClearUp()
        {
            Driver.Quit();
        }
    }
}
