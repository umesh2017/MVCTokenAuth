using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

using System.Web.Http.Cors;


namespace WebApiOauth2.Controllers
{
    [Authorize]
    public class WebApiController : ApiController
    {
    //   [EnableCors(origins: "http://localhost:1707/", headers: "*", methods: "*")]
        // GET api/WebApi
        public IEnumerable<string> Get()
        {
            string userName;
            string designationId;

            //var identity = ClaimsPrincipal.Current;
            //userName= identity.Claims.Where(c => c.Type == ClaimTypes.GroupSid).Select(c => c.Value).SingleOrDefault().ToString();
            //designationId = identity.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).SingleOrDefault().ToString();
            return new string[] { "Hello REST API", "I am Authorized" };
        }

        // GET api/WebApi/5
        public string Get(int id)
        {
            return "Hello Authorized API with ID = " + id;
        }

        // POST api/WebApi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/WebApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/WebApi/5
        public void Delete(int id)
        {
        }
    }
}
