using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Driver;

namespace EPortfolio.Controllers
{
    [RoutePrefix("api")]
    public class EPortfolioController : ApiController
    {


        //Register API
        [Route("register")]
        [HttpPost]
        public IHttpActionResult RegisterUser()
        {
            return Ok();
        }




        // GET: api/EPortfolio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EPortfolio/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EPortfolio
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EPortfolio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EPortfolio/5
        public void Delete(int id)
        {
        }
    }
}
