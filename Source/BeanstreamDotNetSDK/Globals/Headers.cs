using System;
using System.Text;

namespace BeanstreamDotNetSDK.Globals
{
    public static class Headers
    {
        public static string GetAuthorizationHeader()
        {
            var base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", Configuration.MerchantId, Configuration.ProfilesApiPasscode)));
            return string.Format("Passcode {0}", base64Credentials);
        }
    }
}
