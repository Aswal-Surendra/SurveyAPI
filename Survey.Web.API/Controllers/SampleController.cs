using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Survey.Web.API.Controllers
{
    [RoutePrefix("survey")]
    public class SampleController : ApiController
    {
        [HttpGet]
        [Route("GetRecord")]
        public IHttpActionResult FetchData()
        {
            List<string> list = new List<string>();
            list.Add("Ritesh");
            list.Add("Ranjan");
            return Ok(list);
        }
    }
}