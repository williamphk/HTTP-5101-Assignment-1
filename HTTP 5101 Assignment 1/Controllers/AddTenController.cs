using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input {id} when receiving a get request.
        /// <example> GET api/AddTen/5 </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>{id}+10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
