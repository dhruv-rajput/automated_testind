using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppSettings
{
    public class Global
    {
        public static void WaitForElement(IWebDriver driver, By locator, int timeout)
        {
            var Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
        public static void getAndClickElementBYId(IWebDriver driver, string id, int timeout)
        {
            WaitForElement(driver, By.Id(id), timeout);
            IWebElement element = driver.FindElement(By.Id(id));
            element.Click();
        }

        public static void FillTextBoxElementBYId(IWebDriver driver, String id, String text, int timeout)
        {
            WaitForElement(driver, By.Id(id), timeout);
            IWebElement LSTSubmission = driver.FindElement(By.Id(id));
            LSTSubmission.SendKeys(text);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine(id + " has been filled as " + text);
        }

        public static void FrameSwitchGeneric(IWebDriver driver, By locator, int timeout)
        {
            WaitForElement(driver, locator, timeout);
            driver.SwitchTo().Frame(driver.FindElement(locator));
            Console.WriteLine("Frame Switched");
        }

        public static void ClickElementGeneric(IWebDriver driver, By locator, String text, int timeout)
        {
            WaitForElement(driver, locator, timeout);
            IWebElement element = driver.FindElement(locator);
            element.Click();
            Console.WriteLine(text + " Clicked");
        }
        public static void FillTextBoxGeneric(IWebDriver driver, By locator, string ColumnName, string input, int timeout)
        {
            WaitForElement(driver, locator, timeout);
            IWebElement lstsubmission = driver.FindElement(locator);
            lstsubmission.SendKeys(input);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine(ColumnName + " has been filled as " + input);
        }

        public static void ClickElementatIndexGeneric(IWebDriver driver, By locator, int index,string text, int timeout)
        {
            WaitForElement(driver, locator, timeout);
            var list = driver.FindElements(locator);
            list[index].Click();
            Console.WriteLine(text + " Clicked");
        }

        public static void FillTextBoxElementinAnotherElement(IWebDriver driver, By parentelement, By childelement, int index_in_element1, int index_in_element2, string input, string text, int timeout)
        {
            WaitForElement(driver, parentelement, timeout);
            var parent = driver.FindElements(parentelement);
            if (index_in_element2 >= 0)
            {
                var child = parent[index_in_element1].FindElements(childelement);
                child[index_in_element2].SendKeys(input);
            }
            else
            {
                var child = parent[index_in_element1].FindElement(childelement);
                child.SendKeys(input);
            }
            Console.WriteLine(text + "has been filled as" + input);

        }
        public static void SingleSelectDropdowninAnotherElement(IWebDriver driver, By parentelement, By childelement, int index_in_parent, int index_in_dropdown, int timeout)
        {
            var parent = driver.FindElements(parentelement);
            Console.WriteLine(parent.Count);
            var child = parent[index_in_parent].FindElements(childelement);
            Console.WriteLine(child.Count);
            child[index_in_dropdown].Click();
            Console.WriteLine(child[index_in_dropdown].Text + "Selected");
        }
        public static void MultipleSelectDropdowninAnotherElement(IWebDriver driver, By parentelement, By childelement, int index_in_parent, int[] index_in_dropdown, int timeout)
        {
            var parent = driver.FindElements(parentelement);
            Console.WriteLine(parent.Count);
            var child = parent[index_in_parent].FindElements(childelement);
            var length = index_in_dropdown.Length;
            for (int i = 0; i < length; i++)
            {
                child[index_in_dropdown[i]].Click();
                Console.WriteLine(child[index_in_dropdown[i]].Text + "Selected");
                Thread.Sleep(2000);
            }
        }

        public static void FillTextBoxwithDefaultValuesGeneric(IWebDriver driver, By parentelement, By childelement, int index_in_parent, int index_in_child, string input, string text, int timeout)
        {
            var parent = driver.FindElements(parentelement);

            if (index_in_child >= 0)
            {
                var child = parent[index_in_parent].FindElements(childelement);
                child[index_in_child].SendKeys(Keys.Control + "a");
                child[index_in_child].SendKeys(input);
            }
            else
            {
                var child = parent[index_in_parent].FindElement(childelement);
                child.SendKeys(Keys.Control + "a");
                child.SendKeys(input);
            }
            Console.WriteLine(text + "has bee filled as" + input);
        }
    }
}