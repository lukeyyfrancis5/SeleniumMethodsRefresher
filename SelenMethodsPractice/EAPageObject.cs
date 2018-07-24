using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SelenMethodsPractice
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string firstname, string middlename)
        {
            txInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstname);
            txtMiddleName.SendKeys(middlename);
            btnSave.Click();
        }
    }
}
