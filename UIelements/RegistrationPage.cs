using OpenQA.Selenium;

namespace Booking
{
    public class RegistrationPage
    {
        public static IWebElement EmailInput =>
            DriverHolder.Driver.FindElement(By.XPath("//input[@type='email']"));

        public static IWebElement AlertMessage =>
            DriverHolder.Driver.FindElement(By.XPath("//div[@role='alert']"));
        
        public static IWebElement ContinueButton =>
            DriverHolder.Driver.FindElement(By.XPath("//span[contains(text(), 'Continue')]"));

        public static IWebElement CreatePasswordHeading => 
            DriverHolder.Driver.FindElement(By.XPath("//h1[contains(text(), 'Create password')]"));
    }
}
