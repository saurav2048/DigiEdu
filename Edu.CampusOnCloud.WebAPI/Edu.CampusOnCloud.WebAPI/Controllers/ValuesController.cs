﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Edu.CampusOnCloud.WebAPI.Controllers
{
    //[Authorize]

    /// <summary>
    /// This is the sample values api collection
    /// </summary>
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// This is the sample value api
        /// </summary>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
