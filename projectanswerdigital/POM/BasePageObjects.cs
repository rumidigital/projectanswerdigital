using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;


namespace projectanswerdigital.POM
{
    public class BasePageObjects
    {
        public By FadedShortSleeveTshirt = By.XPath(("//img[@alt='Faded Short Sleeve T-shirts'])[1]"));
        public By AddtoCart = By.XPath("//span[text()='Add to cart']");
        public By BasketIcon = By.XPath("//a[@title='View my shopping cart']");
        public By DeleteIcon = By.XPath("//a[@title='Delete']//i[1]");
        public By BannerEmptyCartMessage = By.XPath("//p[text()='Your shopping cart is empty.']");
        public By WomanTab = By.XPath("//a[@title='Women'])[1]");
        public By SummerDressesLink = By.XPath(("//a[@title='Summer Dresses'])[1]"));
        public By SubNavigation = By.XPath("//a[@title='Women']/following-sibling::ul[1]");
        public By SummerDressPage = By.XPath("//span[text()='Summer Dresses ']");
    }

    public class PomModelMethods
    {
        readonly IWebDriver driver;

        public PomModelMethods(ScenarioContext context)
        {
            driver = context["WEB_DRIVER"] as IWebDriver;
        }

        public void FIndELementAndClick(By by)
        {
            driver.FindElement(by).Click();
        }

        public void FindElementAndEnterKeys(By by, String keys)
        {
            driver.FindElement(by).SendKeys(keys);
        }

        public bool FIndElementIsPresent(By by)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
