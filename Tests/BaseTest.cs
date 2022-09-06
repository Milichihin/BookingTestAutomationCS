using NUnit.Framework;

namespace Booking
{
    public class BaseTest
    {
        [SetUp]
        public static void Start()
        {
            DriverHolder.Driver.Manage().Window.Maximize();
            DriverHolder.GoToStartPage();
            WaiterHelper.WaitImplicit();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            //DriverHolder.Driver.Quit();
        }
    }
}
