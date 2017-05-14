using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Mikolo.CoreNet.Base.Service
{
    public class CookiesService : ICookiesService
    {
        public string GetCookieValues(string name, HttpCookieCollection cookies)
        {
            if (!string.IsNullOrEmpty(name) && cookies[name] != null)
            {
                return cookies[name].Value;
            }
            return null;
        }

        public void RemoveCookieValue(string name, HttpCookieCollection cookies)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var currentCookie = cookies[name];
                if (currentCookie != null)
                {
                    cookies.Remove(name);
                    currentCookie.Expires = DateTime.Now.AddDays(-10);
                    currentCookie.Value = null;
                    HttpContext.Current.Response.Cookies.Set(currentCookie);
                }
            }
        }

        public void SetCookieValue(string name, string value, int expiration, HttpCookieCollection cookies)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (cookies[name] == null)
                {
                    var currentCookie = new HttpCookie(name) {
                        Expires = DateTime.Now.AddDays(expiration),
                        Value = value
                    };

                    HttpContext.Current.Response.Cookies.Set(currentCookie);
                }
            }
        }
    }
}
