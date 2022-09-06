using OpenQA.Selenium;

namespace Booking
{
    public class GeneralContext
    {
        private static Random _random = new Random();

        public static string RandomString(int requiredNumberOfCharacters)
        {
            var lettersRow = "abcdefghijklmnopqrstuvwxyz";

            string randomString = "";

            for (int i = 0; i < requiredNumberOfCharacters; i++)
            {
                randomString += lettersRow[_random.Next(0, lettersRow.Length - 1)];
            }

            return randomString;
        }

        public static void InsertTextIntoField(string text, params IWebElement[] fieldsForInsert)
        {
            foreach (var field in fieldsForInsert)
            {
                field.SendKeys(Keys.Control + "a");
                field.SendKeys(Keys.Delete);
                field.SendKeys(text);
            }
        }

        public static void ConvertRequestedDate(string date, 
            out string monthYearCheckIn, 
            out string dateCheckIn, 
            out string monthYearCheckOut, 
            out string dateCheckOut)
        {
            string[] words = date.Split(new char[] { ' ', ',' });

            monthYearCheckIn = $"{words[0]} {words[3]}";
            dateCheckIn = $"{words[1]}";
            monthYearCheckOut = $"{words[5]} {words[8]}";
            dateCheckOut = $"{words[6]}";
        }

        public static void ConvertResultDates( string[] datesSearchResult,
            out string monthYearCheckInResult,
            out string dateCheckInResult,
            out string monthYearCheckOutResult,
            out string dateCheckOutResult)
        {
            string[] checkInDates = datesSearchResult[0].Split(new char[] { ' ' });
            string[] checkOutDates = datesSearchResult[1].Split(new char[] { ' ' });

            monthYearCheckInResult = $"{checkInDates[2]} {checkInDates[3]}";
            dateCheckInResult = $"{checkInDates[1]}";
            monthYearCheckOutResult = $"{checkOutDates[2]} {checkOutDates[3]}";
            dateCheckOutResult = $"{checkOutDates[1]}";
        }

        public static bool IsElementVisible(IWebElement element)
        {
            try
            {
                if (!element.Displayed)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
