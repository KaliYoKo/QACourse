using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
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
             ChromeOptions options = new ChromeOptions
            {
                PlatformName = "windows",
                BrowserVersion = "77.0"
            };
            Driver = new RemoteWebDriver(new Uri("http://192.168.56.1:4444/wd/hub"),options.ToCapabilities(), TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ClearUp()
        {
            Driver.Quit();
        }
    }
}
