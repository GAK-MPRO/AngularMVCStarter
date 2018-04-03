using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A2Rnd.Controllers
{
    public class UserController : Controller
    {
        //this controller should check for token, return unauthorized if the token isinvalid or the token does not present the right claim
        // GET: Public
        public ActionResult Index()
        {
            return View();
        }

       


    }
}