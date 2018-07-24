using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SelenMethodsPractice
{
    class SelenSetMethods
    {
        // Selecting a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
        // Enter Text
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        // Click into button, checkbox, option etc
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropCollection.driver.FindElement(By.Name(element)).Click();
        }
    }
}
