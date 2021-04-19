using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;

namespace DemoAppium
{
    public static class Helper
    {
        public static IOSDriver<IWebElement> InitDriver(){

            DriverOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Safari");
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14.3");
            capabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone X");
            capabilities.AddAdditionalCapability(MobileCapabilityType.Udid, "64db7cab285c74fb6612f63c0bdf8ecda47cc777");
            var driver = new IOSDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);
            return driver;
        }
    }
}