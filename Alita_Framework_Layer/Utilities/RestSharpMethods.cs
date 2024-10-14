// RestSharp Methods for API interactions

using RestSharp;
using System;

public static class RestSharpMethods
{
    public static IRestResponse SendRequest(string baseUrl, string resource, Method method, object body = null, Dictionary<string, string> headers = null)
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest(resource, method);

        if (body != null)
            request.AddJsonBody(body);

        if (headers != null)
        {
            foreach (var header in headers)
                request.AddHeader(header.Key, header.Value);
        }

        return client.Execute(request);
    }
}