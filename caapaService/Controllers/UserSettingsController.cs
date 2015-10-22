using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.Controllers
{
    public class UserSettingsController : ApiController
    {
        public ApiServices Services { get; set; }

        // GET api/UserSettings
        public string Get()
        {
            Services.Log.Info("Hello from custom controller!");
            return "Hello";
        }

    }
}
