using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoAppium.Common
{
    public static class SeleniumExtention
    {
        
        public static void SelectRadioButton(this IWebDriver driver, By buttons, string value)
        {
            driver.WaitUtil(buttons);

            var elements = driver.FindElements(buttons).ToList();

            var elementToSelect = elements.Where(e => e.GetAttribute("value") == value).FirstOrDefault();

            elementToSelect.Click();
        }

        public static void ClickOnCheckBoxes(this IWebDriver driver, By checkboxes, List<string> values)
        {
            driver.WaitUtil(checkboxes);
            var elements = driver.FindElements(checkboxes).ToList();
            foreach (var value in values)
            {
                var elementToSelect = elements.Where(e => e.GetAttribute("value") == value).FirstOrDefault();
                elementToSelect.Click();
            }

        }

        public static void SelectCheckboxes(this IWebDriver driver, By checkboxes, Dictionary<string, bool> values)
        {
            foreach (var value in values)
            {
                driver.SelectCheckbox(checkboxes, value.Key, value.Value);
            }
        }

        public static void SelectCheckbox(this IWebDriver driver, By checkboxes, string value, bool isCheck)
        {
            driver.WaitUtil(checkboxes);
            var elements = driver.FindElements(checkboxes).ToList();
            var elementToSelect = elements.Where(e => e.GetAttribute("value") == value).FirstOrDefault();
            if (elementToSelect.Selected != isCheck)
            {
                elementToSelect.Click();
            }
        }

        public static string SelectItemInMultiSelect(this IWebDriver driver, By multiSelect, string value)
        {
            var multiSelectElement = driver.WaitUtil(multiSelect);
            //Verify that value is not selected before;
            var selectedItem = multiSelectElement.FindElements(By.ClassName("ui-autocomplete-multiselect-item")).Select(s => s.Text).ToList<string>();
            if (selectedItem.Contains(value))
            {
                return "Value is selected before!";
            }

            var itemsSelect = multiSelectElement.FindElements(By.XPath("/..//li/a"));
            var itemToSelect = itemsSelect.Where(s => s.Text == value).FirstOrDefault();

            itemToSelect.Click();

            return "Select successfully!";
        }

        public static void SelectByValue(this IWebDriver driver, By selectBox,string value){
            var element = driver.WaitUtil(selectBox);
            var selectElement = new SelectElement(element);
            
            selectElement.SelectByValue(value); 
        }
    }
}