using BeanstreamDotNetSDK.Domain;
using RestSharp;

namespace BeanstreamDotNetSDK.APIs.Interfaces
{
    public interface IProfilesAPI
    {
        IRestResponse CreateProfile(Profile data);
        IRestResponse UpdateProfile(string profileId, Profile data);
        IRestResponse DeleteProfile(string profileId);
        IRestResponse GetProfile(string profileId);
        IRestResponse GetCards(string profileId);
        IRestResponse AddCard(string profileId, CreditCard card);
        IRestResponse DeleteCard(string profileId, string cardId);
        IRestResponse UpdateCard(string profileId, CreditCard data);
    }
}
