using System;
using BeanstreamDotNetSDK.APIs.Interfaces;
using BeanstreamDotNetSDK.Domain;
using RestSharp;

namespace BeanstreamDotNetSDK.APIs
{
    internal class PaymentsAPI : IPaymentsAPI
    {
        public IRestResponse CreatePayment(Payment data)
        {
            throw new NotImplementedException();
        }

        public IRestResponse GetPayment(string transId, dynamic data)
        {
            throw new NotImplementedException();
        }

        public IRestResponse CancelTransaction(string transId, dynamic data)
        {
            throw new NotImplementedException();
        }

        public IRestResponse CompletePreAuthPayment(string transId, dynamic data)
        {
            throw new NotImplementedException();
        }

        public IRestResponse GetPayment(string transId)
        {
            throw new NotImplementedException();
        }
    }
}
