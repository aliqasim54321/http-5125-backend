using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet_1.Controllers
{
    public class HostingCostController : ApiController
    {/// <summary>
     ///Calculating the hosting cost 
     /// </summary>
     /// <param name="id">The input number will be given by the user</param>
     ///<returns> 1 fortnights at $5.50/FN = $5.50 HST 13% = $0.72 CAD Total = $6.22 CAD</returns>
     ////<returns> 2 fortnights at $5.50/FN = $11.00 HST 13% = $1.43 CAD Total = $12.43 CAD</returns>
     ///<returns>3 fortnights at $5.50/FN = $16.50 HST 13% = $2.15 CAD Total = $18.65 CAD</returns>
        /// post curl -d "" http://localhost:xx/api/HostingCost => 2 fortnights at $5.50/FN = $11.00 HST 13% = $1.43 CAD Total = $12.43 CAD 
        public string Get(int id)
        {
            double Fortnight = 5.50;
            double Hst = 0.13;
            int fortnights = (id / 14) + 1;
            double subtotal = fortnights * Fortnight;
            double TotalHst = subtotal * Hst;
            double total = subtotal + TotalHst;
            return $"{fortnights} fortnights at ${Fortnight:F2}/FN = ${subtotal:F2}"+ $" HST 13% = ${TotalHst:F2} CAD"+ $" Total = ${total:F2} CAD";
        }
    }
}
