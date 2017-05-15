using Newtonsoft.Json.Linq;

namespace Mikolo.CoreNet.Profil.Service
{
    public interface IProfileService
    {
        string GetUserUrn(JObject account);
        void Login(JObject profile, string urn);
        void Logout();
        string GetUsers();
    }
}
