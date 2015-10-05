using BeanstreamDotNetSDK.Domain;
using RestSharp;

namespace BeanstreamDotNetSDK.APIs.Interfaces
{
    public interface IPaymentsAPI
    {
        IRestResponse CreatePayment(Payment data);
        IRestResponse GetPayment(string transId, dynamic data);
        IRestResponse CancelTransaction(string transId, dynamic data);
        IRestResponse CompletePreAuthPayment(string transId, dynamic data);
        IRestResponse GetPayment(string transId);
    }
}
