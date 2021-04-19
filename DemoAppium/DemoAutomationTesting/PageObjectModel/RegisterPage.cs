using System.Collections.Generic;
using System.Linq;
using DemoAppium.Common;
using DemoAppium.DemoAutomationTesting.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoAppium.DemoAutomationTesting.PageObjectModel
{
    public class RegisterPage : BasePage
    {
        private By firstNameInput = By.XPath("//input[@ng-model='FirstName']");
        private By lastNameInput = By.XPath("//input[@ng-model='LastName']");
        private By addressInput = By.XPath("//input[@ng-model='Adress']");
        private By emailAddressInput = By.XPath("//input[@ng-model='EmailAdress']");
        private By genderRadioBtn = By.XPath("//input[@ng-model='Phone']");
        private By hobbiesMultiCheckBox = By.XPath("//*[text()='Hobbies']/..//input");
        private By languagesMultiSelect = By.Id("msdd");
        private By skillsSelect = By.Id("Skills");
        private By countrySelect = By.Id("countries");
        private By selectCountrySelect = By.Id("country");
        private By dateOfBirth_DaySelect = By.Id("daybox");
        private By dateOfBirth_MonthSelect = By.XPath("//Select[@ng-model='monthbox']");
        private By dateOfBirth_YearSelect = By.Id("daybox");
        private By passwordInput = By.Id("firstpassword");
        private By confirmPasswordInput = By.Id("secondpassword");
        private By submitBtn = By.Id("submitbtn");
        private By refreshBtn = By.Id("Button1");

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public RegisterPage GoTo(){
            driver.Navigate().GoToUrl(WebUrl.RegisterPage);

            return this;
        }
        public RegisterPage FillUserInformation(User user)
        {
            driver.WaitUtil(firstNameInput).SendKeys(user.FirstName);
            driver.WaitUtil(lastNameInput).SendKeys(user.LastName);
            driver.WaitUtil(addressInput).SendKeys(user.Address);
            driver.WaitUtil(emailAddressInput).SendKeys(user.EmailAddress);
            driver.SelectRadioButton(genderRadioBtn, user.Gender);
            driver.ClickOnCheckBoxes(hobbiesMultiCheckBox, user.Hobbies);
            driver.SelectItemInMultiSelect(languagesMultiSelect, user.Languages);
            driver.SelectByValue(skillsSelect, user.Skills);
            driver.SelectByValue(countrySelect, user.Country);
            driver.SelectByValue(selectCountrySelect, user.SelectCountry);
            driver.SelectByValue(dateOfBirth_YearSelect, user.DateOfBirth_Year);
            driver.SelectByValue(dateOfBirth_MonthSelect, user.DateOfBirth_Month);
            driver.SelectByValue(dateOfBirth_DaySelect, user.DateOfBirth_Day);
            driver.WaitUtil(passwordInput).SendKeys(user.Password);
            driver.WaitUtil(confirmPasswordInput).SendKeys(user.ConfirmPassword);

            return this;
        }

        public RegisterPage ClickOnSubmit(){  
            driver.WaitUtil(submitBtn).Click();

            return this;
        }



    }
}