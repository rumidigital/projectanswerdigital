using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace projectanswerdigital.Helpers
{
    [Binding]
    public class Testhooks
    {
        [Before]
        public void CreateWebdriver(ScenarioContext context)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            IWebDriver driver = new ChromeDriver();
            context["WEB_DRIVER"] = driver;
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }



        [After]
        public void CloseWebDriver(ScenarioContext context)
        {
            var driver = context["WEB_DRIVER"] as IWebDriver;
            driver.Quit();
        }
    }
}
