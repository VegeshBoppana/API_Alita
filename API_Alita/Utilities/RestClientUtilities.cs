using RestSharp;
using System;

namespace API_Alita.Utilities
{
    public static class RestClientUtilities
    {
        public static IRestResponse SendRequest(string baseUrl, string resource, Method method, object body = null)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, method);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return client.Execute(request);
        }
    }
}