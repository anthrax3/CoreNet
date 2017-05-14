using System;
using Newtonsoft.Json.Linq;
using System.Web.Security;
using System.Web;
using Mikolo.CoreNet.Base.Service;

namespace Mikolo.CoreNet.Profil.Service
{
    public class Auth0ProfileService : IProfileService
    {
        private IRestService RestService;

        public Auth0ProfileService(IRestService restService)
        {
            RestService = restService;
        }

        public string GetUserUrn(JObject account)
        {
            JToken result;
            account.TryGetValue("success", out result);

            if (result.Value<bool>())
            {
                return account.Value<string>("urn");
            }
            return null;
        }

        public void Login(JObject profile, string urn)
        {
            JToken value;
            string firstName = null;
            profile.TryGetValue("consumer", out value);
            if (value != null)
            {
                firstName = value.Value<string>("firstname");
            }

            var username = profile.Value<string>("username");
            if (string.IsNullOrEmpty(firstName) || (string.IsNullOrEmpty(username)))
                return;

            //var virtualUser = AuthenticationManager.BuildVirtualUser("extranet\\" + username, true);
            //virtualUser.Profile.Reload(); // do not remove this line. clean cache for old user

            // You can even work with the profile if you wish
            //virtualUser.Profile.SetCustomProperty("urn", urn);
            //virtualUser.Profile.Email = username;
            //virtualUser.Profile.Name = firstName;

            // Login the virtual user
            //AuthenticationManager.LoginVirtualUser(virtualUser);

            //virtualUser.Profile.Save();
        }

        public void Logout()
        {
            try
            {
                //AuthenticationManager.Logout();
                FormsAuthentication.SignOut();
                HttpContext.Current.Session.Abandon();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encountered in ProfileService.Logout()", ex, this);
                throw;
            }
        }
    }
}
