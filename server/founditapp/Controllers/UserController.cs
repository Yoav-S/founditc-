using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace founditapp.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        // GET: api/users
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("good");
        }

        // GET: api/User/5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Content(HttpStatusCode.OK, "ok");
        }

        // Other actions...
        // POST, PUT, DELETE, etc.
    }
}
