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
        /// This method calculate the total hosting cost by the number of days hosted
        /// </summary>
        /// <param name="days">Number of days</param>
        /// <returns>
        /// 3 strings which describe the total hosting cost plus tax
        /// </returns>
        /// <example>
        /// GET: api/HostingCost/14 -> "2 fortnights at 5.50/FN = $11.00 CAD"
        ///                            "HST 13% = $1.43 CAD"
        ///                            "Total = $12.43 CAD"
        /// </example>
        [Route("api/HostingCost/{days}")]
        public IEnumerable<string> GET(int days)
        {
            double unitPrice = 5.5;
            int fortnights = (int)Math.Ceiling((double)days / 13);
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
