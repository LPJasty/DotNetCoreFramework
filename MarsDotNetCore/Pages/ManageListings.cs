using MarsDotNetCore.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsDotNetCore.Pages
{
    class ManageListings
    {
        #region Intialize elements

        //Find xpath for Manage Listings tab
        private IWebElement manage => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='account-profile-section'/div/section1/div/a3"));

        //Find Xpath for delete icon under Manage Listings
        private IWebElement Delete => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='listing-management-section'/div2/div1/table/tbody/tr1/td8/i3"));

        //Find Xpath for "Yes" button in popup window to delete the record
        private IWebElement clickyes => GlobalDefinitions.driver.FindElement(By.XPath("//button@class = 'ui icon positive right labeled button'"));

        //find Xpath for edit icon button
        private IWebElement edit => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='listing-management-section'/div2/div1/table/tbody/tr3/td8/i2"));

        //Finding Title textbox
        private IWebElement title => GlobalDefinitions.driver.FindElement(By.Name("title"));


        //Finding Description textbox
        private IWebElement Desc => GlobalDefinitions.driver.FindElement(By.Name("description"));


        //find xpath for edit title
        private IWebElement edittitle => GlobalDefinitions.driver.FindElement(By.XPath("//div@class='field error '/input"));

        //find start date for Availablity days
        private IWebElement start => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='service-listing-section'/div2/div/form/div7/div2/div/div1/div2/input"));

        //find start date for Availablity days
        private IWebElement end => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='service-listing-section'/div2/div/form/div7/div2/div/div1/div4/input"));

        //find xpath for upload file
        private IWebElement upload => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='service-listing-section'/div2/div/form/div9/div/div2/section/div/label/div/span/i"));

        //find xpath for save button
        private IWebElement save => GlobalDefinitions.driver.FindElement(By.XPath("//*@id='service-listing-section'/div2/div/form/div11/div/input1"));

        //find xpath for verification
        private IWebElement verifyDelete => GlobalDefinitions.driver.FindElement(By.XPath("//*@id=>'listing-management-section'/div2/div1/table/tbody/tr/td3"));

        //Find Xpath for verification
        private IWebElement SearchRecord => GlobalDefinitions.driver.FindElement(By.XPath("//*@id=>'listing-management-section'/div2/div1/table/tbody/tr/td3"));

        //Find Xpath for next page
        private IWebElement NextPage => GlobalDefinitions.driver.FindElement(By.XPath("//*@id=>'listing-management-section'/div2/div1/div/button4"));

        #endregion


        public void skilldelete()

        {

            //Click on Manage Listings Tab
            manage.Click();
            Thread.Sleep(1000);

            //Click on delete icon
            Delete.Click();
            Thread.Sleep(3000);

            //Click on "Yes" button in popup window to delete the record
            clickyes.Click();
            Thread.Sleep(1000);



            //Verification for 

        }
        //-------------------------------------------------------------------------------------------------------------


        public void EditRecord()

        {
            GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "ShareSkills"); //Populating second sheet of excel sheet
            //Click on Manage Listings Tab
            manage.Click();
            Thread.Sleep(1000);


            //Click on Edit Button
            edit.Click();

            //Clear Title textbox
            title.Clear(); //Clear Title textbox
            Thread.Sleep(1000);

            //Enter Title in title textbox
            title.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "EDITTITLE"));
            Thread.Sleep(1000);

            //Clear Description
            Desc.Clear();
            Thread.Sleep(500);

            //Enter Description
            Desc.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "EDITDESC"));
            Thread.Sleep(1000);

            //Enter Start date for "Avaiability" field
            start.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "EditStart"));
            Thread.Sleep(1000);

            //Enter end date for "Availablitlity" field
            end.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "EditEnd"));
            Thread.Sleep(1000);

            //click on Save button
            save.Click();
            Thread.Sleep(1000);

            //.......................................................................................................................

            //Verification For Edit Record




        }
    }
}
