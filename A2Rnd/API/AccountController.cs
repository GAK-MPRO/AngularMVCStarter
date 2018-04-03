using A2Rnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2Rnd.API
{
    public class AccountController : ApiController
    {

        public IHttpActionResult DoLogin(string userName, string password)
        {

            if (userName == "githubuser" && password == "password")
            {
                //for example purpose.. I am dong hardcoding thec tokem generation. This should be replaced by either OWIN JWT Implementation
                // or your own customer
                return Ok(new User { UserName = userName, Password = password, Token = "A3284783748" });
                    
            }
            else
            {
                return Unauthorized();
            }
            //todo : eventually this should return a token

        }

    }
}
