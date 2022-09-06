using OpenQA.Selenium;

namespace Booking
{
    public class ModalWindow
    {
        public static IWebElement ModalWindowBody =>
            DriverHolder.Driver.FindElement(By.XPath("(//div[@role='dialog'])[2]"));

        public static IWebElement CloseModalWindowButton =>
            DriverHolder.Driver.FindElement(By.XPath("//div[@role='dialog']//button"));
    }
}
