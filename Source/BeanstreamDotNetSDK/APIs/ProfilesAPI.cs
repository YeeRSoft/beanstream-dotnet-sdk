using BeanstreamDotNetSDK.APIs.Interfaces;
using BeanstreamDotNetSDK.Domain;
using BeanstreamDotNetSDK.Globals;
using RestSharp;

namespace BeanstreamDotNetSDK.APIs
{
    internal class ProfilesAPI : IProfilesAPI
    {
        private readonly RestClient _client;

        public ProfilesAPI()
        {
            _client = new RestClient(string.Format(Urls.BaseUrl,Configuration.APIVersion));
        }

        public IRestResponse CreateProfile(Profile data)
        {
            var service = Urls.CreateProfile;

            var request = new RestRequest(service, Method.POST)
            {
                RequestFormat = DataFormat.Json,
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());
            request.AddBody(data);

            return _client.Execute(request);
        }

        public IRestResponse UpdateProfile(string profileId, Profile data)
        {
            var service = string.Format(Urls.UpdateProfile, profileId);

            var request = new RestRequest(service, Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddBody(data);
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());

            return _client.Execute(request);
        }

        public IRestResponse DeleteProfile(string profileId)
        {
            var service = string.Format(Urls.DeleteProfile, profileId);

            var request = new RestRequest(service, Method.DELETE)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());
            return _client.Execute(request);
        }

        public IRestResponse GetProfile(string profileId)
        {
            var service = string.Format(Urls.GetProfile, profileId);

            var request = new RestRequest(service, Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());
            return _client.Execute(request);
        }

        public IRestResponse GetCards(string profileId)
        {
            var service = string.Format(Urls.GetCardsFromProfile, profileId);

            var request = new RestRequest(service, Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());
            return _client.Execute(request);
        }

        public IRestResponse AddCard(string profileId, CreditCard card)
        {
            var service = string.Format(Urls.AddCardToProfile, profileId);

            var request = new RestRequest(service, Method.POST)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());
            request.AddBody(card);

            return _client.Execute(request);
        }

        public IRestResponse DeleteCard(string profileId, string cardId)
        {
            var service = string.Format(Urls.DeleteCardFromProfile, profileId, cardId);

            var request = new RestRequest(service, Method.DELETE)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());

            return _client.Execute(request);
        }

        public IRestResponse UpdateCard(string profileId, CreditCard data)
        {
            var service = string.Format(Urls.UpdateCardToProfile, profileId, data.CardId);

            var request = new RestRequest(service, Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddHeader("Authorization", Headers.GetAuthorizationHeader());

            request.AddBody(new
            {
                card = data
            });

            return _client.Execute(request);
        }
    }
}
