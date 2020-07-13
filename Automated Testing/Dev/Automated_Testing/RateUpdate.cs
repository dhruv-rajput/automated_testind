using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RateUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automated_Testing
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    class RateUpdate
    {
        IWebDriver driver;
        RateMaintainance rateMaintainance;

        [SetUp]
        public void startBrowser()
        {
            //driver = new ChromeDriver();

            driver = new ChromeDriver("D:\\Application");
            rateMaintainance = new RateMaintainance();
        }
        #region RateMaintainance

        [Test]
        public void RM_01_OpenPage_Login()
        {
            rateMaintainance.OpenPage(driver);
        }



        [Test]
        public void RM_05_ScheduleName_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceSchedulemandatory(driver);



                if (check)
                {
                    Console.WriteLine("Schedule name is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Schedule name not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_A_CarCode_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceCarCodemandatory(driver);

                if (check)
                {
                    Console.WriteLine("CarCode is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("CarCode is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_B_DataSource_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceDataSourcemandatory(driver);

                if (check)
                {
                    Console.WriteLine("Data Source is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Data Source is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_C_DaysOut_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceDaysOutmandatory(driver);

                if (check)
                {
                    Console.WriteLine("Days out is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Days out is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_D_ScheduleTime_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceScheduleTimemandatory(driver);

                if (check)
                {
                    Console.WriteLine("Schedule Time is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Schedule Time is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_E_ApplyRule_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceApplyRulemandatory(driver);

                if (check)
                {
                    Console.WriteLine("Apply Rule is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Apply Rule is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_F_EveryDaysOfWeek_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceEveryDaysOfWeekmandatory(driver);

                if (check)
                {
                    Console.WriteLine("Every Days of week is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Every Days of week is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_I_DaysOFWeekLOR_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceDaysOFWeekLORmandatory(driver);

                if (check)
                {
                    Console.WriteLine("Days of week for pickup day is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("Days of week for pickup day is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_05_H_EndAfterOccurence_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceEndAfterOccurencemandatory(driver);

                if (check)
                {
                    Console.WriteLine("End after occurence is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("End after occurence is not empty.");
                    Assert.Fail();
                }

            }

        }



        [Test]
        public void RM_05_G_EndByDate_mandatory()
        {

            {

                bool check = rateMaintainance.RateMaintananceEndByDatemandatory(driver);

                if (check)
                {
                    Console.WriteLine("End by date is empty.");
                    Assert.Pass();
                }
                else
                {
                    Console.WriteLine("End by date is not empty.");
                    Assert.Fail();
                }

            }

        }

        [Test]
        public void RM_02_ScheduleDataAllFields_Filling()
        {
            bool check = rateMaintainance.RateMaintenenceSubmitschedule(driver);

            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }


        [Test]
        public void RM_03_CreateNewCheckBox_Alert()

        {

            bool check = rateMaintainance.RateMaintainanceCreateNewUncheck(driver);

            //var alert = driver.SwitchTo().Alert();
            //Assert.AreEqual(alert.Text);
            //alert.Accept();

            if (check)
                Assert.Pass();
            else
                Assert.Fail();

        }
        [Test]
        public void RM_18_ScheduleCreation_Successfully()
        {
            string check = rateMaintainance.RM_Submitschedule_Success(driver);
            Assert.IsTrue(check.Contains("Schedule Created Successfully!!"));

            //if (check)
            //    Assert.Pass();
            //else
            //    Assert.Fail();
        }

        [Test]
        public void RM_22_ScheduleCreation_AllUnchecked()
        {
            string check = rateMaintainance.RM_ScheduleCreation_AllUnchecked(driver);
            Assert.IsTrue(check.Contains("Schedule Created Successfully!!"));

            //if (check)
            //    Assert.Pass();
            //else
            //    Assert.Fail();
        }

        [Test]
        public void RM_20_ScheduleCreation_Edit()
        {
            bool check = rateMaintainance.RM_Submitschedule_Edit(driver);
            //Assert.IsTrue(check.Contains("Schedule Created Successfully!!"));

            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void RM_21_ScheduleCreation_Delete()
        {
            string check = rateMaintainance.RM_Submitschedule_Delete(driver);
            Assert.IsTrue(check.Contains("Schedulers Deleted"));
            

            //if (check)
            //{
            //    Console.WriteLine("Delete successfully");
            //    Assert.Pass();
            //}
            //else
            //{
            //    Console.WriteLine("Delete unsuccessfully");
            //    Assert.Fail();
            //}
        }

        [Test]
        public void RM_17_ScheduleCreation_Error()
        {
            string check = rateMaintainance.RM_Submitschedule_Error(driver);
            Assert.IsTrue(check.Contains("Some error occured, Please try again!!"));

            //if (check)
            //    Assert.Pass();
            //else
            //    Assert.Fail();
        }


        [Test]

        public void RM_06_SubmitRatesToTetheredLocations_Checked()

        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "chkTetherLocation");

            if (check)
            {
                Console.WriteLine("location tether is checked default");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Location tether isnot checked default");
                Assert.Fail();
            }
        }

        [Test]

        public void RM_07_SubmitToTetheredProducts_checked()

        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "chkTetherProduct");

            if (check)
            {
                Console.WriteLine("Product tether is checked default");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Product tether isnot checked default");
                Assert.Fail();
            }
        }

        [Test]

        public void RM_08_SubmitToTetheredCars_Checked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "chkTetherCar");

            if (check)
            {
                Console.WriteLine("Submit to tethered cars is checked default.");
                Assert.Pass();

            }
            else
            {
                Console.WriteLine("Submit to tethered cars is not checked default.");
                Assert.Fail();
            }

        }

        [Test]

        public void RM_09_Schedule_Is_Active_Checked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "chkScheduleIsActive");

            if (check)

            {
                Console.WriteLine("Schedule is active is checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Schedule is active is not checked default.");
                Assert.Fail();
            }
            Thread.Sleep(2000);


        }

        [Test]

        public void RM_10_Notify_Failure_After_Checked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "chkFileAge");

            if (check)

            {
                Console.WriteLine("Nofity Failed after is checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Nofity Failed after is not checked default.");
                Assert.Fail();
            }

            Thread.Sleep(2000);
            driver.Close();


        }

        [Test]

        public void RM_04_CreateNewSchedule_Checked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "createnew");

            if (check)

            {
                Console.WriteLine("Create New Schedule is checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Create New Schedule is not checked default.");
                Assert.Fail();
            }

        }

        [Test]

        public void RM_11_SubmitExtraHourAndDayRates_Checked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckclick(driver, "createnew");

            if (check)

            {
                Console.WriteLine("Create New Schedule is checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Create New Schedule is not checked default.");
                Assert.Fail();
            }

        }

        [Test]

        public void RM_15_GetRateShoppedData_UnChecked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckunchecked(driver, "chkShopData");

            if (check)

            {
                Console.WriteLine("Get Rate Shopped Data is checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Get Rate Shopped Data is not checked default.");
                Assert.Fail();
            }

            //[TearDown]
        }

        [Test]

        public void RM_12_SubmitOnlyRatesDifferentFromCurrentRate_UnChecked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckunchecked(driver, "chkTetherNotCR");

            if (check)

            {
                Console.WriteLine("Submit only rates different from current rate is not checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Submit only rates different from current rate is checked default.");
                Assert.Fail();
            }

        }

        [Test]

        public void RM_13_SubmitToAllLORs_UnChecked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckunchecked(driver, "chkTetherLor");

            if (check)

            {
                Console.WriteLine("Submit to all LORs is not checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Submit to all LORs is checked default.");
                Assert.Fail();
            }

        }

        [Test]

        public void RM_14_OverrideBlockedDates_UnChecked()
        {
            bool check = rateMaintainance.RatemaintenanceMandatecheckunchecked(driver, "chkOverrideBlockDate");

            if (check)

            {
                Console.WriteLine("Override Blocked Date is not checked default.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Override Blocked Date is checked default.");
                Assert.Fail();
            }

        }



        [Test]

        public void RM_16_IncidentControl_Mins()
        {
            bool check = rateMaintainance.RMincidentcontrolminstext(driver);

            if (check)

            {
                Console.WriteLine("Default Notify failure after is 180.");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Default Notify failure after is not 180.");

                Assert.Fail();
            }

        }

        //[Test]

        //public void RM_19_ManageRule_Button()
        //{
        //    bool check = rateMaintainance.RM_ManageRuleButton(driver);

        //    if (check)

        //    {
        //        Console.WriteLine("Manage Rule Popup open successfully.");
        //        Assert.Pass();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Manage Rule Popup didn't open successfully.");

        //        Assert.Fail();
        //    }

        //}


        [Test]
        public void RM_ManageRule()
        {

            string check = rateMaintainance.RM_ManageRules(driver);
            Assert.IsTrue(check.Contains("Rate Utility"));

            //if (check)
            // Assert.Pass();
            //else
            // Assert.Fail();
        }

        [Test]
        public void RM_ManageRule_ValueRadioDefaultChecked()
        {

            bool check = rateMaintainance.RM_ManageRule_ValueRadioButton(driver);
            //Assert.IsTrue(check.Contains("Rate Utility"));

            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }
        //Load Button
        [Test]
        public void RM_ManageRule_Load()
        {

            bool check = rateMaintainance.RM_ManageRule_Load(driver);


            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }

        //Cross Button
        [Test]
        public void RM_ManageRule_CrossButton()
        {
            bool check = rateMaintainance.RM_ManageRulesCrossButton(driver);
            //Assert.IsTrue(check.Contains("Rate Utility"));

            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }

        //AddRateCondition 
        [Test]
        public void RM_ManageRule_AddRateCondition()
        {
            bool check = rateMaintainance.RM_ManageAddRateCondition(driver);
            //Assert.IsTrue(check.Contains("Rate Utility"));

            if (check)
                Assert.Pass();
            else
                Assert.Fail();
        }

        //Enter Value Field is Mendatory
        [Test]
        public void RM_ManageRule_EnterValueMendatory()
        {
            bool check = rateMaintainance.RM_ManageEnterValueMendatory(driver);
            //Assert.IsTrue(check.Contains("Rate Utility"));

            if (check)

                Assert.Pass();
            else
                Assert.Fail();
        }




        //public void closebrowser()
        //{
        //    driver.Close();
        //}


        #endregion RateMaintainance
    }


}