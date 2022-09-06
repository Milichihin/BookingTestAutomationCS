using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Booking
{
    public class DriverHolder
    {
        private static ChromeDriver _instance;

        public static ChromeDriver Driver
        {
            get
            {
                return _instance ?? (_instance = new ChromeDriver());
            }
        }

        public static void GoToStartPage()
        {
            Driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html");
        }

        public static Actions actions = new Actions(Driver);
    }
}
