using AutoItX3Lib;
using MarsDotNetCore.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsDotNetCore.Pages
{
    class ShareSkills
    {
        #region Intialize elements

        //Finding share skills btn
        private IWebElement shareskillbtn => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'right item']/a"));

        //Finding Title textbox
        private IWebElement title => GlobalDefinitions.driver.FindElement(By.Name("title"));

        //Finding Description textbox
        private IWebElement Desc => GlobalDefinitions.driver.FindElement(By.Name("description"));

        //Find Category Dropdown
        private IWebElement category => GlobalDefinitions.driver.FindElement(By.Name("categoryId"));

        //Find Category "Graphics & Design" from Cateory dropdown
        private IWebElement graphics => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[2]"));

        //Find Category "Digital Marketing" from Cateory dropdown
        private IWebElement Digital => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[3]"));

        //Find Category "Writing & Translation" from Cateory dropdown
        private IWebElement writing => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[4]"));

        //Find Category "Video & Animation" from Cateory dropdown
        private IWebElement video => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[5]"));

        //Find Category "Music & Audio" from Cateory dropdown
        private IWebElement music => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[6]"));

        //Find Category "Programming & Tech" from Cateory dropdown

        private IWebElement programming => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[7]"));
        //Find Category "Business" from Cateory dropdown

        private IWebElement business => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[8]"));

        //Find Category "Fun & Lifestyle" from Cateory dropdown
        private IWebElement fun => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'five wide field']/select/option[9]"));

        //Find SubCategory for Any Category
        private IWebElement Subcategory => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));

        //Finding tag textbox

        private IWebElement tag => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

        //find "Hourly basis service" under Services type
        //[FindsBy(How = How.XPath, Using = "//div[@class = 'ui radio checkbox']/input[@name = 'serviceType' and @value = 0]")]
        private IWebElement radio1 => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'ui radio checkbox']/input[@name = 'serviceType' and @value = 0]"));

        //find "One-off service" under Services type
        // [FindsBy(How = How.XPath, Using = "//div[@class = 'ui radio checkbox']/input[@name = 'serviceType' and @value = 1]")]
        private IWebElement radio2 => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'ui radio checkbox']/input[@name = 'serviceType' and @value = 1]"));

        //verify radio button "Hourly basis services"
        //[FindsBy(How = How.XPath, Using = )]
        private IWebElement radiocheck => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/label"));

        //find location type "on-site"
        //[FindsBy(How = How.XPath, Using = "//div[@class = 'ui radio checkbox']/input[@name = 'locationType' and @value = 0]")]
        private IWebElement onsite => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'ui radio checkbox']/input[@name = 'locationType' and @value = 0]"));

        //find location type "online"
        // [FindsBy(How = How.XPath, Using = "//div[@class = 'ui radio checkbox']/input[@name = 'locationType' and @value = 1]")]
        private IWebElement online => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class = 'ui radio checkbox']/input[@name = 'locationType' and @value = 1]"));

        //verify radio button "on-site"
        private IWebElement path => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/label"));

        //find start date for Availablity days
        private IWebElement start => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

        //find start date for Availablity days
        //[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement end => GlobalDefinitions.driver.FindElement(By.XPath(""));

        //find checkbox for Availablity days

        // [FindsBy(How = How.XPath, Using = "//div[@class = 'ui checkbox']/input[@type = 'checkbox']")]
        // private  IWebElement checkbox =>;
        int k;
        private IWebElement checkbox => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + k + "]/div[1]/div/input"));


        //Find Start time for Availablity days
        private IWebElement starttime => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name ='StartTime']"));

        //Find end time for Availablity days
        private IWebElement endtime => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name ='EndTime']"));
        //Find Skill-exchange radio button under Skill trade field
        private IWebElement skillexchange => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));

        //Find Xpath for Skill-Exchange tags textbox
        private IWebElement skilltags => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/input"));


        //Find Credit radio button under Skill trade field
        private IWebElement credit => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));

        //find xpath for entering value for credit textbox
        private IWebElement creditvalue => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));

        //find xpath for upload file
        private IWebElement upload => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

        //find xpath for "Active" text

        private IWebElement activetext => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/label"));

        //find xpath for "Active" radio button under "Active" field
        private IWebElement active => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));


        //find xpath for "Hidden" radio button
        private IWebElement hidden => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));


        //find xpath for save buuton
        private IWebElement save => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));


        //Find xpath for verification
        private IWebElement test => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/h2"));
        #endregion




        public void AddShareSkills()
        {

            //click on share skills button
            shareskillbtn.Click();
            Thread.Sleep(500);

            GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "ShareSkills"); //Populating second sheet of excel sheet

            //Enter TITLE in Title textbox
            title.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Title"));
            Thread.Sleep(500);

            //Enter Data in Description textbox
            Desc.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Des"));
            Thread.Sleep(500);

            //Select any "Category" and "Sub-Category" from "Category" and "Sub-category" dropdown using switch case

            string st = GlobalDefinitions.ExcelOperations.ReadData(1, "switch");//call value from excelsheet
            int j = Convert.ToInt32(st);//convert string to integar

            switch (j)
            {
                case 1://Select Graphics & Design

                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    graphics.Click();//select graphics and Design option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub = Subcategory;
                    var Element = new SelectElement(sub);//create variable to select any subcategory 
                    Thread.Sleep(1000);
                    Element.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(1, "G&D"));//call sub category from excelsheet
                    break; //exit from switch loop

                case 2: //Select Digital Marketing
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    Digital.Click();//Select Digital Marketing option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub1 = Subcategory;
                    var Element1 = new SelectElement(sub1);//create variable to select any subcategory 
                    Thread.Sleep(1000);
                    Element1.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(3, "DM"));
                    break;


                case 3: //Select Writing and Translation
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    writing.Click();//Select Writing and Translation option 
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub2 = Subcategory;
                    var Element2 = new SelectElement(sub2);//create variable to select any subcategory 
                    Thread.Sleep(1000);
                    Element2.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(4, "W&T"));
                    break;

                case 4: // Select Video and Amination
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    video.Click();// Select Video and Amination option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub3 = Subcategory;
                    var Element3 = new SelectElement(sub3);//create variable to select any subcategory
                    Thread.Sleep(1000);
                    Element3.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(5, "V&A"));
                    break;

                case 5: //Select Music and Video
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    music.Click();//Select Music and Video option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub4 = Subcategory;
                    var Element4 = new SelectElement(sub4);//create variable to select any subcategory
                    Thread.Sleep(1000);
                    Element4.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(2, "M&V"));
                    break;

                case 6: //Select Pogramming and tech
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    programming.Click();//Select Pogramming and tech option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub5 = Subcategory;
                    var Element5 = new SelectElement(sub5);//create variable to select any subcategory
                    Thread.Sleep(1000);
                    Element5.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(6, "P&T"));
                    break;

                case 7: //Select Business
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    business.Click(); //Select Business option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub6 = Subcategory;
                    var Element6 = new SelectElement(sub6);//create variable to select any subcategory
                    Thread.Sleep(1000);
                    Element6.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(7, "Business"));
                    break;

                case 8: //Select Fun & Lifestyle
                    category.Click();//click on category dropdown
                    Thread.Sleep(500);
                    fun.Click();//Select Fun & Lifestyle option
                    Thread.Sleep(500);
                    Subcategory.Click();//click on subcategory dropdown
                    var sub7 = Subcategory;
                    var Element7 = new SelectElement(sub7);//create variable to select any subcategory
                    Thread.Sleep(1000);
                    Element7.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(4, "F&L"));
                    break;

            }

            //Enter Tag

            for (int i = 1; i <= 3; i++)
            {
                tag.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(i, "TAG"));
                Thread.Sleep(1000);
                tag.SendKeys(Keys.Enter);
            }
            Thread.Sleep(500);


            //Select service type

            string bvalue = GlobalDefinitions.ExcelOperations.ReadData(1, "Value");
            string value = radiocheck.Text;// read "Hourly basis services" text using xpath
            if (bvalue == value)
            {
                radio1.Click();//"Hourly basis services" radio buuton
                Thread.Sleep(1500);
            }
            else
            {
                radio2.Click();//"One-off service" radio button
                Thread.Sleep(1500);
            }


            // Select Location type 
            string bvalue1 = GlobalDefinitions.ExcelOperations.ReadData(1, "Location");
            string value1 = path.Text;//read "on-site" text using xpath
            if (bvalue1 == value1)
            {
                onsite.Click();//onsite radio button
                Thread.Sleep(2500);

            }
            else
            {
                online.Click();//online radio button
                Thread.Sleep(500);
            }

            // Select Availability days field
            //Set start date for Availability

            start.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Start"));
            Thread.Sleep(2000);

            //Enter end date for Availablitlity
            end.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "End"));
            Thread.Sleep(2000);

            //Click on checkbox button for days 
            //for (int k = 2; k < 4; k++)
            //{

            //    checkbox.Click();//click on check box for days selected(mon-sun)
            //    Thread.Sleep(3000);
            //    starttime.ElementAt(i).SendKeys(GlobalDefinitions.ExcelOperations.ReadData(i, "STARTIME"));//enter start time for each day selected
            //    Thread.Sleep(3000);
            //    endtime.ElementAt(i).SendKeys(GlobalDefinitions.ExcelOperations.ReadData(i + 2, "ENDTIME"));//enter end time for each day selected
            //    Thread.Sleep(1000);
            //    continue;
            //}

            //Select any skill trade
            string option1 = "first";//declaring random string for comparing

            if (option1 == GlobalDefinitions.ExcelOperations.ReadData(1, "SkillTrade"))
            {
                for (int i = 1; i <= 2; i++)
                {
                    skillexchange.Click();//click on skill exchange radio button
                    Thread.Sleep(500);
                    skilltags.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(i, "SkillTags"));//enter various services in textbox under skill-exchange radio button
                    Thread.Sleep(1000);
                    skilltags.SendKeys(Keys.Enter);

                }

            }
            else
            {
                credit.Click();//click on credit radio button
                creditvalue.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Amount"));//enter amount charged for credit 
            }
            //upload files

            upload.Click();
            Thread.Sleep(1000);
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            Thread.Sleep(1000);
            auto.Send(GlobalDefinitions.ExcelOperations.ReadData(2, "Upload"));
            Thread.Sleep(1000);
            auto.Send("{ENTER}");

            //select any "Active" field
            string comp1 = GlobalDefinitions.ExcelOperations.ReadData(1, "Active");
            string comp2 = activetext.Text;
            if (comp1 == comp2)
            {
                active.Click();
                Thread.Sleep(500);
            }
            else
            {
                hidden.Click();
                Thread.Sleep(500);
            }

            //Click on Save button
            save.Click();
            Thread.Sleep(2000);

            //VERIFICATION



        }


    }
}
