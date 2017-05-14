using Mikolo.CoreNet.Profil.Service;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mikolo.CoreNet.Web.Controllers
{
    public class DefaultController : Controller
    {
        private IProfileService ProfileService;

        public DefaultController(IProfileService profileService)
        {
            ProfileService = profileService;
        }
        // GET: Default
        public ActionResult Index()
        {
            // var jObject = new JObject();
            // jObject.Value<string>("");
            if (ProfileService != null)
                ViewBag.Success = "profile service here";
            return View();
        }
    }
}