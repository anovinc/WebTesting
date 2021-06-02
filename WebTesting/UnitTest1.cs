using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class AddingItemToCart
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheAddingItemToCartTest()
        {
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            driver.FindElement(By.XPath("//div[@id='SidebarContent']/a/img")).Click();
            driver.FindElement(By.LinkText("FI-FW-02")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
            driver.FindElement(By.Name("img_cart")).Click();
        }


        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }

    [TestFixture]
    public class SearchingProduct
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSearchingProductTest()
        {
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            driver.FindElement(By.Name("keyword")).Click();
            driver.FindElement(By.Name("keyword")).Clear();
            driver.FindElement(By.Name("keyword")).SendKeys("golden");
            driver.FindElement(By.Name("searchProducts")).Click();
            driver.FindElement(By.Name("keyword")).Click();
            driver.FindElement(By.LinkText("Great family dog")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

    [TestFixture]
    public class LoginUser
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheLoginUserTest()
        {
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("user543");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | name=password | ]]
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("sifra");
            driver.FindElement(By.Name("signon")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }


    [TestFixture]
    public class UpdatingCountOfItems
    {
        private IWebDriver driver;
    private StringBuilder verificationErrors;
    private string baseURL;
    private bool acceptNextAlert = true;

    [SetUp]
    public void SetupTest()
    {
        driver = new FirefoxDriver();
        baseURL = "https://www.google.com/";
        verificationErrors = new StringBuilder();
    }

    [TearDown]
    public void TeardownTest()
    {
        try
        {
            driver.Quit();
        }
        catch (Exception)
        {
            // Ignore errors if unable to close the browser
        }
        Assert.AreEqual("", verificationErrors.ToString());
    }

    [Test]
    public void TheUpdatingCountOfItemsTest()
    {
        driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
        driver.FindElement(By.XPath("//div[@id='SidebarContent']/a[2]/img")).Click();
        driver.FindElement(By.LinkText("K9-RT-02")).Click();
        driver.FindElement(By.LinkText("Add to Cart")).Click();
        driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
        driver.FindElement(By.XPath("//div[@id='SidebarContent']/a[5]/img")).Click();
        driver.FindElement(By.LinkText("AV-SB-02")).Click();
        driver.FindElement(By.LinkText("Add to Cart")).Click();
        driver.FindElement(By.Name("EST-22")).Click();
        driver.FindElement(By.Name("EST-22")).Clear();
        driver.FindElement(By.Name("EST-22")).SendKeys("3");
        driver.FindElement(By.Name("updateCartQuantities")).Click();
    }
    private bool IsElementPresent(By by)
    {
        try
        {
            driver.FindElement(by);
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    private bool IsAlertPresent()
    {
        try
        {
            driver.SwitchTo().Alert();
            return true;
        }
        catch (NoAlertPresentException)
        {
            return false;
        }
    }

    private string CloseAlertAndGetItsText()
    {
        try
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            if (acceptNextAlert)
            {
                alert.Accept();
            }
            else
            {
                alert.Dismiss();
            }
            return alertText;
        }
        finally
        {
            acceptNextAlert = true;
        }
    }
    }

    [TestFixture]
    public class AddingOneMoreItemAndRemovingOneItemFromCart
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheAddingOneMoreItemAndRemovingOneItemFromCartTest()
        {
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            driver.FindElement(By.XPath("//div[@id='SidebarContent']/a[2]/img")).Click();
            driver.FindElement(By.LinkText("K9-RT-02")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Add to Cart')])[3]")).Click();
            driver.FindElement(By.LinkText("Remove")).Click();
            driver.FindElement(By.Name("updateCartQuantities")).Click();
            driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
            driver.FindElement(By.Name("img_cart")).Click();
            driver.FindElement(By.Name("updateCartQuantities")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

    [TestFixture]
    public class ProcedingToCheckout
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheProcedingToCheckoutTest()
        {
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("user543");
            driver.FindElement(By.XPath("//div[@id='Catalog']/form/p[2]")).Click();
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | name=password | ]]
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("sifra");
            driver.FindElement(By.XPath("//div[@id='Catalog']/form/p[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='Catalog']/form/p[2]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //div[@id='Catalog']/form/p[2] | ]]
            driver.FindElement(By.Name("signon")).Click();
            driver.FindElement(By.XPath("//div[@id='SidebarContent']/a/img")).Click();
            driver.FindElement(By.LinkText("FI-SW-01")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
            driver.FindElement(By.XPath("//div[@id='SidebarContent']/a[5]/img")).Click();
            driver.FindElement(By.LinkText("AV-CB-01")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.XPath("//div[@id='LogoContent']/a/img")).Click();
            driver.FindElement(By.XPath("//div[@id='SidebarContent']/a[2]/img")).Click();
            driver.FindElement(By.LinkText("K9-DL-01")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.Name("img_cart")).Click();
            driver.FindElement(By.Name("EST-9")).Click();
            driver.FindElement(By.Name("EST-9")).Clear();
            driver.FindElement(By.Name("EST-9")).SendKeys("2");
            driver.FindElement(By.Id("Cart")).Click();
            driver.FindElement(By.Name("updateCartQuantities")).Click();
            driver.FindElement(By.LinkText("Proceed to Checkout")).Click();
            driver.FindElement(By.Name("order.creditCard")).Click();
            driver.FindElement(By.Name("order.creditCard")).Click();
            driver.FindElement(By.Name("order.cardType")).Click();
            driver.FindElement(By.XPath("//form[@action='/actions/Order.action']")).Click();
            driver.FindElement(By.Name("order.expiryDate")).Click();
            driver.FindElement(By.Name("order.expiryDate")).Clear();
            driver.FindElement(By.Name("order.expiryDate")).SendKeys("12/2003");
            driver.FindElement(By.Name("newOrder")).Click();
            driver.FindElement(By.LinkText("Confirm")).Click();
            driver.FindElement(By.LinkText("Return to Main Menu")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

}
