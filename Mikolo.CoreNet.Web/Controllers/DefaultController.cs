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
        private readonly IProfileService _profileService;

        public DefaultController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        // GET: Default
        public ActionResult Index()
        {
            var result = string.Empty;

            result = _profileService.GetUsers();
            ViewBag.Success = result;

            return View();
        }
    }
}