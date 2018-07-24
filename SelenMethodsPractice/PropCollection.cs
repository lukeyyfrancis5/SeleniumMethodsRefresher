using OpenQA.Selenium;

namespace SelenMethodsPractice
{
    enum PropertyType
    {
        Id,
        Name,
        CssName,
        ClassName,
        LinkText
    }
    class PropCollection
    {
        // Auto- implemented property
        public static IWebDriver driver { get; set; }
    }
}
