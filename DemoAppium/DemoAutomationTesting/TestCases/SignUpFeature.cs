using DemoAppium.DemoAutomationTesting.Model;
using DemoAppium.DemoAutomationTesting.PageObjectModel;
using DemoAppium.TestCases;
using NUnit.Framework;

namespace DemoAppium.DemoAutomationTesting.TestCases
{
    public class SignUpFeature : BaseTest
    {
        RegisterPage registerPage;

        [Test]
        public void SignUp_Successfully(){
            User user = new User();
            user.FirstName = "aaa";
            user.LastName = "a";

            registerPage = new RegisterPage(driver);
            registerPage
                .GoTo()
                .FillUserInformation(user);
        }
    }
}