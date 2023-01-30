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
        /// This method return an integer after applying four mathematical operations to the integer input {id}
        /// <example> GET api/NumberMachine/2</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>{id}+{id}-{id}*{id}/{id}</returns>
        public int GET(int id)
        {
            return id + id - id * id / id;
        }
    }
}
