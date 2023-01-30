using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of integer input {id}
        /// <example> GET api/Square/10 </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>{id}*{id}</returns>
        public int GET(int id)
        {
            return id*id;
        }
    }
}
