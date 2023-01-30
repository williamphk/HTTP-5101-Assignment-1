using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5101_Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns 3 strings which describe the total hosting cost.
        /// <example> GET api/HostingCost/14 </example>
        /// </summary>
        /// <param name="id"> Number of days </param>
        /// <returns>{fortnights} fortnights at ${unitPrice}/FN = ${initialPrice} CAD 
        /// HST {tax}% = ${taxPrice} CAD
        /// Total = ${totalPrice} CAD</returns> 
        public IEnumerable<string> GET(int id)
        {
            double unitPrice = 5.5;
            int fortnights = (int)Math.Ceiling((double)id / 13);
            double initialPrice = unitPrice * fortnights;
            string string1 = fortnights + " fortnights at " + unitPrice.ToString("0.00") + "/FN = $" + initialPrice.ToString("0.00")+ " CAD";

            int tax = 13;
            double taxPrice = Math.Round(initialPrice * tax / 100,2);
            string string2 = "HST "+ tax + "% = $" + taxPrice + " CAD";

            double totalPrice = initialPrice + taxPrice;
            string string3 = "Total = $" + totalPrice + " CAD";
            return new string[] { string1, string2, string3 };

        }
    }
}
