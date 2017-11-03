using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TracingWeb.Models;

namespace TracingWeb.Controllers
{
    public class PerformancesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Set(string name, int cpu, int memory)
        {
            Perfomance.Count++;
            return Ok();
        }

        [HttpGet]
        public long Get()
        {
            return Perfomance.Count;
        }

        [HttpGet]
        public string GetName()
        {
            if (Perfomance.AvailName.Count > 0)
                return Perfomance.AvailName.Pop();
            return "";
        }

        [HttpGet]
        public int GetAvail()
        {
            return Perfomance.AvailName.Count;
        }
    }
}
