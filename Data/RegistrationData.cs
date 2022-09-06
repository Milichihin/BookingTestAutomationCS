namespace Booking
{
    public class RegistrationData
    {
        public static readonly string correctEmail = $"{GeneralContext.RandomString(5)}@correctEmail.com";
        public static readonly string incorrectEmail = $"{GeneralContext.RandomString(5)}correctEmail.com";
    }
}
