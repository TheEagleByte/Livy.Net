using RestSharp;

namespace Livy.Net
{
    public static class RestExtensions
    {
        public static RestRequest AddDefaultHeader(this RestRequest request, string username)
        {
            request.AddHeader("X-Requested-By", username);
            return request;
        }
    }
}