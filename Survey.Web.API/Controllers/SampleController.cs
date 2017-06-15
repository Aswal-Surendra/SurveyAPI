using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RapidSitecore.Foundation.Logging;


namespace Survey.Web.API.Controllers
{
    [RoutePrefix("survey")]
    public class SampleController : ApiController
    {
        [HttpGet]
        [Route("GetRecord")]
        public IHttpActionResult FetchData()
        {
            LogManager.Info("Start");
            List<string> list = new List<string>();
            list.Add("Ritesh");
            list.Add("Ranjan");            
            return Json(list);
        }
    }
}