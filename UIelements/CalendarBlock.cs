using OpenQA.Selenium;

namespace Booking
{
    public class CalendarBlock
    {
        public static IWebElement Month =>
            DriverHolder.Driver.FindElement(By.XPath("(//div[@class='bui-calendar__month'])[2]"));

        public static List<IWebElement> DateList => 
            DriverHolder.Driver.FindElements(
                    By.XPath("(//table[@class='bui-calendar__dates'])[2]//tr[@class='bui-calendar__row']/td/span")
                    ).ToList();

        public static IWebElement NextMonthButton =>
            DriverHolder.Driver.FindElement(By.XPath("//div[@data-bui-ref='calendar-next']"));
    }
}
