namespace Booking
{
    public class CalendarContext
    {
        public static void ChooseDate(string date)
        {
            GeneralContext.ConvertRequestedDate(
            date,
            out string monthYearCheckIn,
            out string dateCheckIn,
            out string monthYearCheckOut,
            out string dateCheckOut
            );

            MainPage.CheckInButton.Click();

            while (CalendarBlock.Month.Text != monthYearCheckIn)
            {
                CalendarBlock.NextMonthButton.Click();
            }

            if (CalendarBlock.Month.Text == monthYearCheckIn)
            {
                foreach (var element in CalendarBlock.DateList)
                {
                    if (element.Text == dateCheckIn)
                    {
                        element.Click();
                    }
                }
            }

            while (CalendarBlock.Month.Text != monthYearCheckOut)
            {
                CalendarBlock.NextMonthButton.Click();
            }

            if (CalendarBlock.Month.Text == monthYearCheckOut)
            {
                foreach (var element in CalendarBlock.DateList)
                {
                    if (element.Text == dateCheckOut)
                    {
                        element.Click();
                    }
                }
            }
        }
    }
}
