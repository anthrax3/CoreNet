using RestSharp;
using System.Collections.Generic;

namespace Mikolo.CoreNet.Base.Service
{
    public interface IRestService
    {
        string GetResponse(string url, string username, string password);
        string PostRequest(string url, string username, string password, Dictionary<string, string> formdata);
        string PutRequest(string url, string username, string password, Dictionary<string, string> formdata);
        string SendRequest(string url, string username, string password, Dictionary<string, string> formdata, Method method);
    }
}
