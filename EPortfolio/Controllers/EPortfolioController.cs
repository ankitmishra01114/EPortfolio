using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EPortfolio.Models;
using MongoDB.Driver;

namespace EPortfolio.Controllers
{
    [RoutePrefix("api")]
    public class EPortfolioController : ApiController
    {


        //Register API
        [Route("register")]
        [HttpPost]
        public IHttpActionResult RegisterUser([FromBody] RegisterUser user)
        {
            try
            {
                
                return Ok();
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }
    }
}
