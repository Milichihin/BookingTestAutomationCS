using OpenQA.Selenium;

namespace Booking
{
    public class MainPage
    {
        public static IWebElement SearchField => 
            DriverHolder.Driver.FindElement(By.XPath("//input[@type='search']"));
        
        public static IWebElement SearchButton => 
            DriverHolder.Driver.FindElement(By.XPath("//button[@class='sb-searchbox__button ']"));

        public static IWebElement CheckInButton =>
            DriverHolder.Driver.FindElement(By.XPath("(//div[@class='sb-date-field b-datepicker'])[1]"));

        public static IWebElement RegisterButton =>
            DriverHolder.Driver.FindElement(By.XPath("(//span[contains(text(), 'Register')])[1]"));

    }
}
