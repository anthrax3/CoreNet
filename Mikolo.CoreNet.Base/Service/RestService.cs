using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Authenticators;

namespace Mikolo.CoreNet.Base.Service
{
    public class RestService : IRestService
    {
        public string GetResponse(string url, string username, string password)
        {
            var result = string.Empty;

            try
            {
                var client = new RestClient(url) { Authenticator = new HttpBasicAuthenticator(username, password) };
                var request = new RestRequest(Method.GET);

                var response = client.Execute(request) as RestResponse;
                result = response.Content;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error on connecting with Auth0 service : " + e);
            }

            return result;
        }

        public string PostRequest(string url, string username, string password, Dictionary<string, string> formdata)
        {
            return SendRequest(url, username, password, formdata, Method.POST);
        }

        public string PutRequest(string url, string username, string password, Dictionary<string, string> formdata)
        {
            return SendRequest(url, username, password, formdata, Method.PUT);
        }

        public string SendRequest(string url, string username, string password, Dictionary<string, string> formdata, Method method)
        {
            string result;
            try
            {
                var restClient = new RestClient(url) { Authenticator = new HttpBasicAuthenticator(username, password) };
                var request = new RestRequest(method);

                foreach (var keyValuePair in formdata)
                {
                    request.AddParameter(keyValuePair.Key, keyValuePair.Value, ParameterType.GetOrPost);
                }

                var restResponse = restClient.Execute(request);
                result = restResponse.Content;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while authenticating GRS user", ex);
                result = string.Empty;
            }

            return result;
        }
    }
}
