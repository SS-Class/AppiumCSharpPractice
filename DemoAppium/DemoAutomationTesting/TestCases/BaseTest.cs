using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoAppium.TestCases
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        
        [OneTimeSetUp()]
        public void BeforeAll()
        {
            driver = Helper.InitDriver();
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            driver.Quit();
        }

    }
}