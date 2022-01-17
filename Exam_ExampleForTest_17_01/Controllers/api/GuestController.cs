using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exam_ExampleForTest_17_01.Controllers.api
{
    public class GuestController : ApiController
    {
        // GET: api/Guest
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // GET: api/Guest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Guest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Guest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Guest/5
        public void Delete(int id)
        {
        }
    }
}
