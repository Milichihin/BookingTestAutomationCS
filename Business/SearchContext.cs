using OpenQA.Selenium;

namespace Booking
{
    public class SearchContext
    {
        public static bool IsResultsAllContainsWord(string word, List<IWebElement> addressesList, out int trueResult)
        {
            bool result = true;
            trueResult = 0;

            foreach (var address in addressesList)
            {
                if (address.Text.Contains(word))
                {
                    result = true;
                    trueResult++;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool DoesRequestedDateMatched(string date, string[] datesSearchResult)
        {
            GeneralContext.ConvertRequestedDate(date,
            out string monthYearCheckIn,
            out string dateCheckIn,
            out string monthYearCheckOut,
            out string dateCheckOut);

            GeneralContext.ConvertResultDates(datesSearchResult,
            out string monthYearCheckInResult,
            out string dateCheckInResult,
            out string monthYearCheckOutResult,
            out string dateCheckOutResult);

            return monthYearCheckIn == monthYearCheckInResult 
                && dateCheckIn == dateCheckInResult
                && monthYearCheckOut == monthYearCheckOutResult
                && dateCheckOut == dateCheckOutResult
                ? true : false;
        }
    }
}
