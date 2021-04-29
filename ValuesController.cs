using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    [RoutePrefix("api/controllers/data")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Archive(int year, int month, int day)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //api/controllers/data
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "Malik" };
        }

        //api/controllers/data/AddCustomer?customer=blabla
        [Route("AddCustomer")]
        [HttpPost]
        public void Addcustomer (string customer)
        {

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
