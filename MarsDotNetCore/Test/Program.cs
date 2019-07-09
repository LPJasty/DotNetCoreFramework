using MarsDotNetCore.Global;
using MarsDotNetCore.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace MarsDotNetCore
{
    [TestClass]
    public class Program
    {

        [TestMethod]
        public void CoreTestSignUp()
        {
            using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {


                SignUp newSignUp = new SignUp();
                newSignUp.Register();


            }
        }

        [TestMethod]
        public void CoreTestSignIn()
        {

            using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {

                SignIn newSignIn = new SignIn();
                newSignIn.LoginSteps();

            }

        }

        [TestMethod]

        public void CoreTestProfile()
        {
            using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                SignIn newSIgnIn = new SignIn();
                newSIgnIn.LoginSteps();
                Profile newProfile = new Profile();
                newProfile.ProfileSteps();
            }


        }

        [TestMethod]

        public void CoreTestShareSkills()
        {
            using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                SignIn newSIgnIn = new SignIn();
                newSIgnIn.LoginSteps();
                ShareSkills Newshareskill = new ShareSkills();
                Newshareskill.AddShareSkills();


            }


        }


        [TestMethod]

        public void CoreTestManageListings()
        {
            using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                SignIn newSIgnIn = new SignIn();
                newSIgnIn.LoginSteps();
                ManageListings newManage = new ManageListings();
                newManage.EditRecord();
                newManage.skilldelete();
            }

        }

    }
}
