using System.Web;

namespace Mikolo.CoreNet.Base.Service
{
    public interface ICookiesService
    {
        string GetCookieValues(string name, HttpCookieCollection cookies);
        void SetCookieValue(string name, string value, int expiration, HttpCookieCollection cookies);
        void RemoveCookieValue(string name, HttpCookieCollection cookies);
    }
}
