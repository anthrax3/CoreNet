using System;
using System.Collections.Generic;
using RestSharp;

namespace Mikolo.CoreNet.Profil.Service
{
    public class ProfileService : IProfileService
    {
        private static string Token { get; set; }

        private static string TokenType { get; set; }

        private static string TokenUrl = "https://henintsoa.eu.auth0.com/oauth/token";
        
        public void Initialize()
        {
            try
            {
                var restClient = new RestClient(TokenUrl);
                var request = new RestRequest(Method.POST);

                request.AddHeader("content-type", "application/json");
                request.AddParameter(
                    "application/json",
                    "{\"client_id\":\"FzghnCh-Upu_5lFsDKinZg4N_ls2bxMs\",\"client_secret\":\"XLq8A_lww0-ZFzvOCSdRy4P4UQSiKfppimloQuSvIwTL8LMfWuHKV73bAl5nUn8b\",\"audience\":\"https://henintsoa.eu.auth0.com/api/v2/\",\"grant_type\":\"client_credentials\"}", 
                    ParameterType.RequestBody
                );

                var response = restClient.Execute(request) as RestResponse;
            
                Token = response.Content;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on authenticating with Auth0 service : " + ex.Message);
            }
        }

        public string GetResponse(string url, string username, string password)
        {
            throw new NotImplementedException();
        }

        public string PostRequest(string url, string username, string password, Dictionary<string, string> formdata)
        {
            throw new NotImplementedException();
        }

        public string PutRequest(string url, string username, string password, Dictionary<string, string> formdata)
        {
            throw new NotImplementedException();
        }

        public string SendRequest(string url, string username, string password, Dictionary<string, string> formdata, Method method)
        {
            throw new NotImplementedException();
        }
    }
}
