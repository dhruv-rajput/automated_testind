using AppSettings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RateUpdate
{

    public class RateMaintainance
    {
        public object SeleniumExtras { get; private set; }

        public void OpenPage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://cargain.rategain.com/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();

            Global.FillTextBoxGeneric(driver, By.Name("userName"), "UserName", "Economy.Toronto", 2);


            Global.FillTextBoxGeneric(driver, By.Name("password"), "PassWord", "RG@2018", 2);



            Global.ClickElementGeneric(driver, By.Id("btnLogin"), "Login Button", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("navRateUpdate"), "Rate Update", 30);

            Thread.Sleep(10000);
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 50);

            Thread.Sleep(8000);
            Global.ClickElementGeneric(driver, By.Id("addRateMaintenance"), "+Rate Maintenence", 30);
        }



        public bool MendetorySelectSchedule(IWebDriver driver)
        {
            return true;
        }

        public bool RateMaintananceCarCodemandatory(IWebDriver driver)
        {

            OpenPage(driver);

            Thread.Sleep(5000);

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 009", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //IWebElement CarCD = driver.FindElement(By.Id("mat-input-13"));
            //CarCD.Click();

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);

            IWebElement CarCDdeselect = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[2]/div[5]/div/multiple-select/div[1]/div/mat-card/mat-card-header/div[2]/div/div[2]/a[2]"));
            CarCDdeselect.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("mat-input-11"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }


        public bool RateMaintananceSchedulemandatory(IWebDriver driver)
        {

            OpenPage(driver);

            Thread.Sleep(5000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("NewScheduleName"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }


        public bool RateMaintananceDataSourcemandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);


            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[3]/div[1]/div[3]/div/multiple-select/div/mat-form-field/div/div[1]/div/input"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }


        public bool RateMaintananceDaysOutmandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("daysout"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }

        public bool RateMaintananceScheduleTimemandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("mat-input-18"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }

        public bool RateMaintananceApplyRulemandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 10);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 10);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("applyrule"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }

        public bool RateMaintananceEveryDaysOfWeekmandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 10);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 10);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Days of week

            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("mat-input-19"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }

        public bool RateMaintananceDaysOFWeekLORmandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Days of Week
            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            IWebElement DOWDeslect = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[3]/div[2]/div/mat-card/mat-card-content/div[2]/div[1]/multiple-select/div[1]/div/mat-card/mat-card-header/div[2]/div/div[2]/a[2]"));
            DOWDeslect.Click();

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 10);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 10);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Days of week

            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("mat-input-19"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }


        public bool RateMaintananceEndAfterOccurencemandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 10);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 10);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Days of week

            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //End after selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "End After Radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("occurrences"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }



        public bool RateMaintananceEndByDatemandatory(IWebDriver driver)

        {
            OpenPage(driver);

            Thread.Sleep(5000);

            //Schedule Name

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Rategain 001", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Days out select 

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 10);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 10);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Days of week

            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //End after selection

            Global.ClickElementGeneric(driver, By.Id("every22"), "End By Date Radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            // Inactive Schedule

            IWebElement CHInactive = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[7]/div[2]/mat-card/mat-card-content/div[1]/div/mat-checkbox/label/div"));
            CHInactive.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Schedule inactive");

            // Submit Schedule

            Thread.Sleep(5000);

            IWebElement CLSubmit = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button/div[2]"));
            Thread.Sleep(5000);
            CLSubmit.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Console.WriteLine("Successfully clicked on Save button.");

            Thread.Sleep(5000);


            IWebElement TXTReport = driver.FindElement(By.Id("endby"));
            var classes = TXTReport.GetAttribute("className");
            var length = classes.Count();
            // Console.WriteLine();
            return classes.Contains("ng-invalid") && (classes.Contains("ng-valid") || classes.Contains("ng-invalid"));

        }

        public bool RateMaintenenceSubmitschedule(IWebDriver driver)
        {
            OpenPage(driver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "Test Report 18", 100);

            //Submission Type
            Global.FillTextBoxGeneric(driver, By.Id("submissionType"), "SubmissionType", "Manual", 30);


            //PickupLocation
            Global.FillTextBoxGeneric(driver, By.Id("pickupLocation"), "Pickuplocation", "YYZ", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropoffLocation
            Global.FillTextBoxGeneric(driver, By.Id("dropoffLocation"), "Dropofflocation", "YYZ", 30);

            //Product Code
            Global.FillTextBoxGeneric(driver, By.Id("productcode"), "Product Code", "3Day", 30);

            //LOR
            Global.FillTextBoxGeneric(driver, By.Id("lor"), "LOR", "3", 30);

            //Car Code
            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("a"), 0, 1, 30);
            int[] carcodeindexes = { 2, 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("span"), 0, carcodeindexes, 30);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Day out 

            Thread.Sleep(5000);

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //Days of Week of date range

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-header"), By.TagName("a"), 0, 1, 30);
            int[] daysofweekindexes = { 0, 2, 4, 6, 8, 10, 12 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, daysofweekindexes, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //PickTime Selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 13, 0, "06:00PM", "PickupTime", 30);


            //DropTime selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 14, 0, "06:00PM", "DropoffTime", 30);


            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            //StartDate Selection
            Global.FillTextBoxwithDefaultValuesGeneric(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 19, 0, "7/31/2020", "StartDate", 30);

            //Occurrence selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "Occurrence Selection", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxGeneric(driver, By.Id("occurrences"), "Occurrence", "2", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "akash.soni@Rategain.com", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Inactive Schedule
            Global.ClickElementGeneric(driver, By.Name("chkScheduleIsActive"), "Inactivate schedule", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            Thread.Sleep(5000);

            return true;
        }


        public bool RateMaintainanceCreateNewUncheck(IWebDriver driver)

        {
            OpenPage(driver);

            //RateMaintananceSchedulemandatory(driver);

            Thread.Sleep(3000);

            Global.ClickElementGeneric(driver, By.Name("createnew"), "Create New unchecked.", 20);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Submission Type
            Global.FillTextBoxGeneric(driver, By.Id("submissionType"), "SubmissionType", "Manual", 30);


            //PickupLocation
            Global.FillTextBoxGeneric(driver, By.Id("pickupLocation"), "Pickuplocation", "YYZ", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropoffLocation
            Global.FillTextBoxGeneric(driver, By.Id("dropoffLocation"), "Dropofflocation", "YYZ", 30);

            //Product Code
            Global.FillTextBoxGeneric(driver, By.Id("productcode"), "Product Code", "3Day", 30);

            //LOR
            Global.FillTextBoxGeneric(driver, By.Id("lor"), "LOR", "3", 30);

            //Car Code
            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("a"), 0, 1, 30);
            int[] carcodeindexes = { 2, 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("span"), 0, carcodeindexes, 30);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Day out 

            Thread.Sleep(5000);

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //Days of Week of date range

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-header"), By.TagName("a"), 0, 1, 30);
            int[] daysofweekindexes = { 0, 2, 4, 6, 8, 10, 12 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, daysofweekindexes, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //PickTime Selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 13, 0, "06:00PM", "PickupTime", 30);


            //DropTime selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 14, 0, "06:00PM", "DropoffTime", 30);


            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            //StartDate Selection
            Global.FillTextBoxwithDefaultValuesGeneric(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 19, 0, "7/31/2020", "StartDate", 30);

            //Occurrence selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "Occurrence Selection", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxGeneric(driver, By.Id("occurrences"), "Occurrence", "2", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "akash.soni@Rategain.com", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Inactive Schedule
            Global.ClickElementGeneric(driver, By.Name("chkScheduleIsActive"), "Inactivate schedule", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            //Thread.Sleep(5000);



            //string Alert = driver.SwitchTo().Alert().Text;
            //Console.WriteLine(Alert);







            return true;
        }

        public bool RatemaintenanceMandatecheckclick(IWebDriver driver, string chkId)

        {
            OpenPage(driver);

            //Global.ClickElementGeneric(driver, By.Id(chkId), "Check box is selected defaultly.", 20);
            //var chktether = 

            IWebElement CHKMandate = driver.FindElement(By.Id(chkId));
            var checktether = CHKMandate.GetAttribute("className");
            // var length = checktether.Count();
            //Console.WriteLine("");
            return checktether.Contains("checkbox-checked");

        }

        public bool RatemaintenanceMandatecheckunchecked(IWebDriver driver, string chkId)

        {
            OpenPage(driver);

            //Global.ClickElementGeneric(driver, By.Id(chkId), "Check box is selected defaultly.", 20);
            //var chktether = 

            IWebElement CHKMandate = driver.FindElement(By.Id(chkId));
            var checktether = CHKMandate.GetAttribute("className");
            // var length = checktether.Count();
            //Console.WriteLine("");
            return checktether.Contains("mat-checkbox mat-accent ng-untouched ng-pristine ng-valid");

            //driver.Close();
        }

        public string RM_Submitschedule_Success(IWebDriver driver)
        {
            OpenPage(driver);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //RateMaintenenceSubmitschedule(driver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "TestSchedulePOC", 100);

            //Submission Type
            Global.FillTextBoxGeneric(driver, By.Id("submissionType"), "SubmissionType", "Manual", 30);


            //PickupLocation
            Global.FillTextBoxGeneric(driver, By.Id("pickupLocation"), "Pickuplocation", "YYZ", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropoffLocation
            Global.FillTextBoxGeneric(driver, By.Id("dropoffLocation"), "Dropofflocation", "YYZ", 30);

            //Product Code
            Global.FillTextBoxGeneric(driver, By.Id("productcode"), "Product Code", "3Day", 30);

            //LOR
            Global.FillTextBoxGeneric(driver, By.Id("lor"), "LOR", "3", 30);

            //Car Code
            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("a"), 0, 1, 30);
            int[] carcodeindexes = { 2, 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("span"), 0, carcodeindexes, 30);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Day out 

            Thread.Sleep(5000);

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //Days of Week of date range

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-header"), By.TagName("a"), 0, 1, 30);
            int[] daysofweekindexes = { 0, 2, 4, 6, 8, 10, 12 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, daysofweekindexes, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //PickTime Selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 13, 0, "06:00PM", "PickupTime", 30);


            //DropTime selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 14, 0, "06:00PM", "DropoffTime", 30);


            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            //StartDate Selection
            Global.FillTextBoxwithDefaultValuesGeneric(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 19, 0, "7/31/2020", "StartDate", 30);

            //Occurrence selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "Occurrence Selection", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxGeneric(driver, By.Id("occurrences"), "Occurrence", "2", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "akash.soni@rategain.com", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Inactive Schedule
            Global.ClickElementGeneric(driver, By.Name("chkScheduleIsActive"), "Inactivate schedule", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            Thread.Sleep(1000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string Success = driver.FindElement(By.XPath("//div[@class='to-title toastr-title ng-star-inserted']")).Text;
            IWebElement Alert = driver.FindElement(By.XPath("//span[@class='to-message toastr-message ng-star-inserted']"));
            string alt = Alert.Text;
            Console.WriteLine(Success + " " + alt);

            return alt;
        }

        public string RM_ScheduleCreation_AllUnchecked(IWebDriver driver)
        {
            OpenPage(driver);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //RateMaintenenceSubmitschedule(driver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "gdftwertwertertsdfxx", 100);

            //Submission Type
            Global.FillTextBoxGeneric(driver, By.Id("submissionType"), "SubmissionType", "Manual", 30);


            //PickupLocation
            Global.FillTextBoxGeneric(driver, By.Id("pickupLocation"), "Pickuplocation", "YYZ", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropoffLocation
            Global.FillTextBoxGeneric(driver, By.Id("dropoffLocation"), "Dropofflocation", "YYZ", 30);

            //Product Code
            Global.FillTextBoxGeneric(driver, By.Id("productcode"), "Product Code", "3Day", 30);

            //LOR
            Global.FillTextBoxGeneric(driver, By.Id("lor"), "LOR", "3", 30);

            //Car Code
            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("a"), 0, 1, 30);
            int[] carcodeindexes = { 2, 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("span"), 0, carcodeindexes, 30);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Day out 

            Thread.Sleep(5000);

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //Days of Week of date range

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-header"), By.TagName("a"), 0, 1, 30);
            int[] daysofweekindexes = { 0, 2, 4, 6, 8, 10, 12 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, daysofweekindexes, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //PickTime Selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 13, 0, "06:00PM", "PickupTime", 30);


            //DropTime selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 14, 0, "06:00PM", "DropoffTime", 30);


            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            //StartDate Selection
            Global.FillTextBoxwithDefaultValuesGeneric(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 19, 0, "7/31/2020", "StartDate", 30);

            //Occurrence selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "Occurrence Selection", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxGeneric(driver, By.Id("occurrences"), "Occurrence", "2", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "akash.soni@rategain.com", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // All check boxes unchecked
            Global.ClickElementGeneric(driver, By.Id("chkTetherLocation"), "Inactivate Tether Location", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("chkTetherProduct"), "Inactivate Tether Product", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.Id("chkTetherCar"), "Inactivate Tether car", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.Id("chkScheduleIsActive"), "Inactivate Schedule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.Id("chkFileAge"), "Inactivate FileAge", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            Thread.Sleep(1000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string Success = driver.FindElement(By.XPath("//div[@class='to-title toastr-title ng-star-inserted']")).Text;
            IWebElement Alert = driver.FindElement(By.XPath("//span[@class='to-message toastr-message ng-star-inserted']"));
            string alt = Alert.Text;
            Console.WriteLine(Success + " " + alt);

            return alt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public bool RM_Submitschedule_Edit(IWebDriver driver)
        {
            OpenPage(driver);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        
            Thread.Sleep(3000);

            Global.ClickElementGeneric(driver, By.Name("createnew"), "Create New unchecked.", 20);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Select Schedule
            Global.FillTextBoxGeneric(driver, By.Id("scheduleName"), "Select Schedule", "Test_RateGain_Auto_11", 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "c@c.com", 30);

            Thread.Sleep(1000);


            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            Thread.Sleep(1000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string Success = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]")).Text;
            IWebElement Alert = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/span"));
            string alt = Alert.Text;
            Console.WriteLine(Success + " " + alt);



            return true;

        }

        

        public string RM_Submitschedule_Delete(IWebDriver driver)
        {
            OpenPage(driver);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Thread.Sleep(3000);

            //Global.ClickElementGeneric(driver, By.Name("createnew"), "Create New unchecked.", 20);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Select Schedule
            Global.FillTextBoxGeneric(driver, By.Id("scheduleName"), "Select Schedule", "dgsddhe4777345", 10);



            // Delete Schedule
            Thread.Sleep(3000);
            //Global.ClickElementGeneric(driver, By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[2]/button"), "Delete", 20);

            IWebElement BTNDEL = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[2]/button"));

            //BTNDEL.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", BTNDEL);

            IWebElement DELPP = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container"));

            string DeletePopup = DELPP.Text;

            //Console.WriteLine("A window with title, {DeletePopup}" + " deleted");

            Thread.Sleep(3000);

            IWebElement DELCNF = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-confirm-dialog/div/div/button[1]"));
            DELCNF.Click();
            Console.WriteLine("Delete button clicked to delete scheduler.");


            IWebElement SuccessDEL = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/span"));
            Console.WriteLine(SuccessDEL.Text);

            return SuccessDEL.Text;

            


            //Thread.Sleep(3000);


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //string Success = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]")).Text;
            //IWebElement Alert = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/span"));
            //string alt = Alert.Text;
            //Console.WriteLine(Success + " " + alt);



            //return true;

        }


        public string RM_Submitschedule_Error(IWebDriver driver)
        {
            OpenPage(driver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxElementBYId(driver, "NewScheduleName", "dgsddheDKSINGH", 100);

            //Submission Type
            Global.FillTextBoxGeneric(driver, By.Id("submissionType"), "SubmissionType", "Manual", 30);


            //PickupLocation
            Global.FillTextBoxGeneric(driver, By.Id("pickupLocation"), "Pickuplocation", "YYZ", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropoffLocation
            Global.FillTextBoxGeneric(driver, By.Id("dropoffLocation"), "Dropofflocation", "YYZ", 30);

            //Product Code
            Global.FillTextBoxGeneric(driver, By.Id("productcode"), "Product Code", "3Day", 30);

            //LOR
            Global.FillTextBoxGeneric(driver, By.Id("lor"), "LOR", "3", 30);

            //Car Code
            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            Global.ClickElementatIndexGeneric(driver, By.ClassName("chosen-choices"), 0, "Car Code", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("a"), 0, 1, 30);
            int[] carcodeindexes = { 2, 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card"), By.TagName("span"), 0, carcodeindexes, 30);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "Select Overlay Div", 30);


            // Data Source

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 8, "DataSource", 60);
            Thread.Sleep(5000);


            int[] datasource = { 0 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 0, datasource, 30);

            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            // Schedule Time Selection
            Global.ClickElementGeneric(driver, By.Id("mat-input-18"), "Schedule Time", 10);

            driver.SwitchTo().ParentFrame();
            Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 30);

            int[] timeindexes = { 4 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, timeindexes, 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //Day out 

            Thread.Sleep(5000);

            Global.ClickElementGeneric(driver, By.Id("dtrRadio2"), "DayOut", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Thread.Sleep(5000);
            Global.FillTextBoxGeneric(driver, By.Id("daysout"), "Dayout", "10-20", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //Days of Week of date range

            Global.ClickElementatIndexGeneric(driver, By.ClassName("mat-form-field-infix"), 12, "Days of week range", 30);
            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-header"), By.TagName("a"), 0, 1, 30);
            int[] daysofweekindexes = { 0, 2, 4, 6, 8, 10, 12 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 1, daysofweekindexes, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);

            //PickTime Selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 13, 0, "06:00PM", "PickupTime", 30);


            //DropTime selection
            Global.FillTextBoxElementinAnotherElement(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 14, 0, "06:00PM", "DropoffTime", 30);


            Thread.Sleep(5000);
            Global.ClickElementGeneric(driver, By.Id("every12"), "Day Of Week radio button", 10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.ClickElementGeneric(driver, By.Id("mat-input-19"), "Day of Week input tag", 10);

            int[] daysofweek = { 2, 6 };
            Global.MultipleSelectDropdowninAnotherElement(driver, By.ClassName("mat-card-content"), By.TagName("span"), 2, daysofweek, 30);

            Global.ClickElementGeneric(driver, By.ClassName("select-overlay"), "select-overlay", 10);


            //StartDate Selection
            Global.FillTextBoxwithDefaultValuesGeneric(driver, By.ClassName("mat-form-field-infix"), By.TagName("input"), 19, 0, "7/31/2020", "StartDate", 30);

            //Occurrence selection

            Global.ClickElementGeneric(driver, By.Id("every21"), "Occurrence Selection", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Global.FillTextBoxGeneric(driver, By.Id("occurrences"), "Occurrence", "2", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Rule Selection

            Global.ClickElementGeneric(driver, By.Id("applyrule"), "ApplyRule", 30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Global.SingleSelectDropdowninAnotherElement(driver, By.ClassName("ng-trigger"), By.TagName("span"), 24, 1, 30);

            //Email Address
            Global.FillTextBoxGeneric(driver, By.Id("emailaddress"), "Email", "akash.soni@rategain.com", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Inactive Schedule
            Global.ClickElementGeneric(driver, By.Name("chkScheduleIsActive"), "Inactivate schedule", 30);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Submit Schedule
            Thread.Sleep(3000);
            Global.ClickElementGeneric(driver, By.XPath("html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[8]/div[2]/div[1]/button"), "Save", 30);

            Thread.Sleep(1000);
            string Opps = driver.FindElement(By.XPath("//div[@class='to-title toastr-title ng-star-inserted']")).Text;
            IWebElement Warn = driver.FindElement(By.XPath("//span[@class='to-message toastr-message ng-star-inserted']"));
            string ale = Warn.Text;
            Console.WriteLine(Opps + " " + ale);


            //string Success = driver.FindElement(By.XPath("//div[@class='to-title toastr-title ng-star-inserted']")).Text;
            //IWebElement Alert = driver.FindElement(By.XPath("//span[@class='to-message toastr-message ng-star-inserted']"));
            //string alt = Alert.Text;
            //Console.WriteLine(Success + " " +alt);

            return ale;
        }

        public bool RMincidentcontrolminstext(IWebDriver driver)
        {
            OpenPage(driver);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement TXTMin = driver.FindElement(By.Id("mins"));
            var TXTMinValue = TXTMin.GetAttribute("value");
            TXTMinValue.Contains("180");


            return true;
        }

        //public bool RM_ManageRuleButton(IWebDriver driver)

        //{
        //    OpenPage(driver);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        //    //Thread.Sleep(5000);
        //    //Global.FrameSwitchGeneric(driver, By.Id("rateUpdateIframe"), 60);

        //    Global.WaitForElement(driver, By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]"),10);

        //    IWebElement BTNManageRule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[2]"));
        //    BTNManageRule.Submit();


        //    return true;
        //}

        //////////// GLOBAL ManageRule method ////////////

        public void ManageRules(IWebDriver driver)
        {
            //Open Ratemaintenance Page
            OpenPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);

            //Find the Manage Rule Button
            IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);

            //Click on manage Rule Button
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", Managerule);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);
        }


        public string RM_ManageRules(IWebDriver driver)
        {

            ManageRules(driver);
            // //Open Ratemaintenance Page
            // OpenPage(driver);
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Thread.Sleep(3000);

            // //Find the Manage Rule Button
            // IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Thread.Sleep(3000);

            ////Click on manage Rule Button
            // IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            // executor.ExecuteScript("arguments[0].click();", Managerule);
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            // Thread.Sleep(3000);

            //Find the Title of opened window
            IWebElement RateU = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/h3"));
            string RateUtility = RateU.Text;
            Console.WriteLine("Manage Rule button clicked and A window with title " + RateUtility + " opened");
            return RateUtility;
        }

        public bool RM_ManageRule_ValueRadioButton(IWebDriver driver)
        {
            ManageRules(driver);
            //OpenPage(driver);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Managerule);

            IWebElement Value = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/form/table/tbody/tr[7]/td[2]/mat-radio-group/mat-radio-button[2]"));
            var ValueAttribute = Value.GetAttribute("class");
            Console.WriteLine(ValueAttribute);
            Console.WriteLine("Value Radio Button is default checked");
            //Console.WriteLine(Value.Text);

            return ValueAttribute.Contains("mat-radio-checked");
        }

        //Manage Rule Load Button

        public bool RM_ManageRule_Load(IWebDriver driver)
        {
            ManageRules(driver);
            //Open RateMaintenance
            //OpenPage(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ////Click Manage Rule button
            //Thread.Sleep(30);
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Managerule);

            //Find the Saved Rules Element
            IWebElement SavedRules = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/form/table/tbody/tr[23]/td[2]/tbody/tr/td[1]/select"));

            //Select the Rules
            SelectElement Saved = new SelectElement(SavedRules);
            Saved.SelectByText("10percent");
            //Console.WriteLine(SavedRules.GetAttribute("class"));
            //SavedRules.SendKeys("10percent");

            //Find the Load button
            IWebElement Load = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[2]/button[1]"));
            //IWebElement Load = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[2]/button[1]/div[1]"));
            Thread.Sleep(2000);
            Console.WriteLine(Load.GetAttribute("class"));

            //Click on Load Button
            IJavaScriptExecutor Load1 = (IJavaScriptExecutor)driver;
            Load1.ExecuteScript("arguments[0].click();", Load);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Console.WriteLine(SavedRules.GetAttribute("ng-reflect-model") + " Rule loaded successfully");
            //Load.Click();
            return Load.GetAttribute("class").Contains("btn-orange mat-button");

        }

        //Cross Button
        public bool RM_ManageRulesCrossButton(IWebDriver driver)
        {
            ManageRules(driver);
            //OpenPage(driver);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Thread.Sleep(3000);
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Managerule);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Thread.Sleep(3000);

            IWebElement CrossB = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/div/button/div[1]"));
            var CrossBAttribute = CrossB.GetAttribute("class");
            //Console.WriteLine(CrossBAttribute);
            Thread.Sleep(3000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            executor1.ExecuteScript("arguments[0].click();", CrossB);

            Console.WriteLine("Clicked on CrossButton");
            //Console.WriteLine(Value.Text);

            return CrossBAttribute.Contains("mat-button-ripple mat-ripple");

        }

        //Add Rate Condition 

        public bool RM_ManageAddRateCondition(IWebDriver driver)
        {

            ManageRules(driver);
            ////Open RateMaintenance
            //OpenPage(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Thread.Sleep(2000);
            ////Find the ManageRule Button
            //IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            ////Click Manage Rule button
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Managerule);
            //Thread.Sleep(30);

            //Find the Add Rate Condition
            IWebElement AddRate = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/form/table/tbody/tr[1]/td/table/tbody/tr/td[2]/a"));
            Thread.Sleep(3000);

            //Click on AddRateCondtion

            AddRate.Click();
            //Find the deletetooltip
            IWebElement DeleteToolTip = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/form/table/tbody/tr[2]/td/table/tbody/tr[1]/td[1]/button/span/mat-icon"));
            //Thread.Sleep(3000);
            //DeleteToolTip.Click();
            return DeleteToolTip.Text.Contains("delete");

        }

        //Enter Value Field is Mendatory
        public bool RM_ManageEnterValueMendatory(IWebDriver driver)
        {

            ManageRules(driver);
            ////Open RateMaintenance
            //OpenPage(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Thread.Sleep(2000);
            ////Find the ManageRule Button
            //IWebElement Managerule = driver.FindElement(By.XPath("/html/body/app-root/div/app-main/app-home/app-rate-maintenance/div/div/div/div/div[2]/form/div[6]/div[1]/div[2]/div[2]/button/div[1]"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            ////Click Manage Rule button
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Managerule);
            //Thread.Sleep(3000);

            //Find the Enter Value text box
            IWebElement EnterValue = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[1]/form/table/tbody/tr[11]/td[2]/mat-form-field/div/div[1]/div/input"));

            //Find the Save Rule Button
            IWebElement SaveRule = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-manage-rule/div[2]/button[2]/div[1]"));
            //Click on Save Rule Button
            IJavaScriptExecutor SaveRule1 = (IJavaScriptExecutor)driver;
            SaveRule1.ExecuteScript("arguments[0].click();", SaveRule);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //SaveRule.Click();

            //Find the Error message
            IWebElement Erroralert = driver.FindElement(By.XPath("/html/body/div[4]/div/div"));
            string Erroralerttxt = Erroralert.Text;
            Console.WriteLine(Erroralerttxt);
            return Erroralerttxt.Contains("Fields with * are mandatory");

        }

    }
}
