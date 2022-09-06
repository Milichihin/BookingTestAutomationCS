namespace Booking
{
    public class WaiterHelper
    {
        public static void WaitImplicit()
        {
            DriverHolder.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WaitersData.timeForWaitImplicit);
        }
    }
}
