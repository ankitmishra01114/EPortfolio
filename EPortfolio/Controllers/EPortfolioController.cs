using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EPortfolio.Controllers
{
    public class EPortfolioController : ApiController
    {
        // GET: api/EPortfolio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EPortfolio/5
        public string Get(int ids)
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
