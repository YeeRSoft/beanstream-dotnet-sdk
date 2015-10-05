using RestSharp;

namespace BeanstreamDotNetSDK.APIs.Interfaces
{
    public interface IReportsAPI
    {
        IRestResponse GetReports(dynamic query);
    }
}
