using System.Collections.Generic;
using OpenQA.Selenium;

namespace DemoAppium.DemoAutomationTesting.Model
{
    public class User
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public string EmailAddress {get; set;}
        public string Gender {get; set;}
        public List<string> Hobbies;
        public string Languages {get; set;}
        public string Skills {get; set;}    
        public string Country {get; set;}
        public string SelectCountry {get; set;}
        public string DateOfBirth {get; set;}
        public string DateOfBirth_Day {get; set;}
        public string DateOfBirth_Month {get; set;}
        public string DateOfBirth_Year {get; set;}
        public string Password {get; set;}
        public string ConfirmPassword {get; set;}
    }
}