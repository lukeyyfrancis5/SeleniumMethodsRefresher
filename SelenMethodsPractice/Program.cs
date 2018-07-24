using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenMethodsPractice
{
    class Program
    {
        

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
           PropCollection.driver = new ChromeDriver();
            // Navigate to Google page
            PropCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void ExecuteTest()
        {

            // Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("LF", "Luke", "Brandon");






            //// Title
            //SelenSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //// Initial
            //SelenSetMethods.EnterText("Initial", "B", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SelenGetMethods.GetText("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SelenGetMethods.GetText("Initial", PropertyType.Name));

            //// Click 
            //SelenSetMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            PropCollection.driver.Close();
        }
    }
}
