namespace BeanstreamDotNetSDK.Globals
{
    public class Urls
    {
        public static string BaseUrl = "https://www.beanstream.com/api/{0}";

        //profiles urls
        public static string CreateProfile = "/profiles";
        public static string UpdateProfile = "/profiles";
        public static string DeleteProfile = "/profiles/{0}";
        public static string GetProfile = "/profiles/{0}";
        public static string GetCardsFromProfile = "/profiles/{0}/cards";
        public static string AddCardToProfile = "/profiles/{0}/cards";
        public static string DeleteCardFromProfile = "/profiles/{0}/cards/{1}";
        public static string UpdateCardToProfile = "/profiles/{0}/cards/{1}";

        //payments urls
        public static string CreatePayment = "/payments";
        public static string GetPayment = "/payments/{0}/returns";
        public static string CancelTransaction = "/payments/{0}/void";
        public static string CompletePayment = "/payments/{0}/completions";
        public static string GetPreviousPayment = "/payments/{0}";

    }
}
