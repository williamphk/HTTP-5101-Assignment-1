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
        /// This function add 10 to the integer input 
        /// </summary>
        /// <param name="number">integer input</param>
        /// <returns>
        /// 10 more than the integer input
        /// number: 5 -> 15
        /// </returns>
        /// <example> 
        /// GET: api/AddTen/5 -> 15
        /// </example>
        [Route("api/AddTen/{number}")]
        public int Get(int number)
        {
            return number + 10;
        }
    }
}
