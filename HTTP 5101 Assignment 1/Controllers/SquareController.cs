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
        /// This function calculate the square of the integer input
        /// </summary>
        /// <param name="number">integer input</param>
        /// <returns>
        /// the square of integer input
        /// number: 10 -> 100
        /// </returns>
        /// <example> 
        /// GET: api/Square/10 -> 100
        /// </example>
        [Route("api/Square/{number}")]
        public int GET(int number)
        {
            return number * number;
        }
    }
}
