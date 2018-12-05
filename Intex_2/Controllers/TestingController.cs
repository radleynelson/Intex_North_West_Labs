using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Intex_2.Controllers
{
    [Authorize]
    public class TestingController : ApiController
    {
        // GET: api/Testing
     
        public IEnumerable<string> Get()
        {
            var test = User;
            return new string[] { "value1", "value2" };
        }

        // GET: api/Testing/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Testing
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Testing/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Testing/5
        public void Delete(int id)
        {
        }
    }
}
