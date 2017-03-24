using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FbTesting.Controllers
{
    public class LikesController : Controller
    {
        //
        // GET: /Likes/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

    }
}
