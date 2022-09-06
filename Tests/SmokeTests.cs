using NUnit.Framework;

namespace Booking.Tests
{
    public class SmokeTests : BaseTest
    {
        [Test]
        public void SearchTest()
        {
            // variable for the message to display in case of failure
            int trueResult;

            GeneralContext.InsertTextIntoField(SearchData.city, MainPage.SearchField);

            CalendarContext.ChooseDate(SearchData.date);

            MainPage.SearchButton.Click();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(
                SearchContext.IsResultsAllContainsWord(
                    SearchData.city,
                    SearchResultPage.HotelsAddressesResults,
                    out trueResult
                    ),
                $"There is at least one mismatch in search result. \n" +
                $"Expected: {SearchData.city} {SearchResultPage.HotelsAddressesResults.Count} times;\n" +
                $"Result: {SearchData.city} {trueResult} times."
                );

                Assert.IsTrue(
                SearchContext.DoesRequestedDateMatched(SearchData.date, SearchResultPage.datesSearchResult),
                $"There is at least one mismatch in search result. \n" +
                $"Expected: {SearchData.date};\n" +
                $"Result: {SearchResultPage.datesSearchResult[0]} - {SearchResultPage.datesSearchResult[1]}."
                );
            });
        }

        [Test]
        public void CheckIncorrectEmail()
        {
            MainPage.RegisterButton.Click();

            GeneralContext.InsertTextIntoField(RegistrationData.incorrectEmail, RegistrationPage.EmailInput);

            RegistrationPage.ContinueButton.Click();

            Assert.IsTrue(
                GeneralContext.IsElementVisible(RegistrationPage.AlertMessage)
                );
        }

        [Test]
        public void CheckCorrectEmail()
        {
            MainPage.RegisterButton.Click();

            GeneralContext.InsertTextIntoField(RegistrationData.correctEmail, RegistrationPage.EmailInput);

            RegistrationPage.ContinueButton.Click();

            Assert.IsTrue(
                GeneralContext.IsElementVisible(RegistrationPage.CreatePasswordHeading)
                );
        }
    }
}
