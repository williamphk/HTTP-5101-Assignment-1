using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This function returns the string "Hello World! using POST method
        /// </summary>
        /// <returns>
        /// "Hello World!"
        /// </returns>
        /// <example>
        /// POST api/Greeting -> "Hello World!"
        /// </example>
        [Route("api/Greeting")]
        public string POST()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns the string “Greetings to {number} people!” where number is an integer value."
        /// </summary>
        /// <param name="number">number of people</param>
        /// <returns>
        /// a string greeting the number of people
        /// number: 6 -> "Greetings to 6 people!"
        /// </returns>
        /// <example>
        /// GET: api/Greeting/6  -> "Greetings to 6 people!"
        /// </example>
        [Route("api/Greeting/{number}")]
        public string GET(int number)
        {
            return "Greetings to " + number + " people!";
        }
    }
}
