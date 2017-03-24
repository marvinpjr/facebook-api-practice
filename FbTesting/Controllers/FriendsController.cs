using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FbTesting.Views.Home
{
    public class FriendsController : Controller
    {
        //
        // GET: /Friends/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

    }
}
