using OpenQA.Selenium;

namespace Booking
{
    public class SearchResultPage
    {
        public static List<IWebElement> HotelsAddressesResults =>
            DriverHolder.Driver.FindElements(
                    By.XPath("//span[@data-testid='address']")
                    ).ToList();

        public static string DateCheckInResult => 
            DriverHolder.Driver.FindElement(
                By.XPath("//button[@data-testid='date-display-field-start']")).Text; 

        public static string DateCheckOutResult =>
            DriverHolder.Driver.FindElement(
                By.XPath("//button[@data-testid='date-display-field-end']")).Text;

        public static string[] datesSearchResult = { DateCheckInResult, DateCheckOutResult };
    }
}
