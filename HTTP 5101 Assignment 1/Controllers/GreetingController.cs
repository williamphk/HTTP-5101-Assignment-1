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
        /// This method returns the string "Hello World!"
        /// <example> POST api/Greeting </example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string POST()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns the string “Greetings to {id} people!” where id is an integer value."
        /// <example> GET api/Greeting/6 </example>
        /// </summary>
        /// <returns>"Greetings to {id} people!"</returns>
        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
