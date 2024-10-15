using RestSharp;
using System;

namespace API_Alita.Utilities
{
    public static class RestClientMethods
    {
        public static IRestResponse SendGetRequest(string baseUrl, string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            return client.Execute(request);
        }
    }
}