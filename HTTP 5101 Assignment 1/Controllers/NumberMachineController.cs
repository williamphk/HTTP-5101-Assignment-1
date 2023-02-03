using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method calculate the result by applying four mathematical operations
        /// </summary>
        /// <param name="number">integer input</param>
        /// <returns>
        /// an integer after applying four mathematical operations to the integer input
        /// number: 2 -> 2
        /// </returns>
        /// <example> 
        /// GET: api/NumberMachine/2 -> "2"
        /// </example>
        [Route("api/NumberMachine/{number}")]
        public int GET(int number)
        {
            return number + number - number * number / number;
        }
    }
}
