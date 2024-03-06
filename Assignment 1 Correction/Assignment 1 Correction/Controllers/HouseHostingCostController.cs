using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/// <summary>
/// Calculates and returns the hosting cost, tax amount, and total amount based on the number of days.
/// </summary>
/// <param name="days">The total number of days for which the hosting cost is calculated.</param>
/// <returns>
/// Returns an IEnumerable<string> containing strings representing the breakdown of costs, tax, and total amount.
/// </returns>
///< example >
///     GET /api/HostingCost/3 ->   “2 fortnights at $5.50/FN = $11.00 CAD”
///                                 “HST 13% = $1.43 CAD”
///                                 “Total = $12.43 CAD”
/// </example>

namespace Assignment_1_Correction.Controllers
{
    public class HouseHostingCostController : ApiController
    {
        [Route("api/HouseHostingCost/{days}")]
        public IEnumerable<string> Get (int Days)
           
        {
            double costPerFortnight = 5.50;
            double taxRate = 0.13;
            int fortnightDays = 14;

            int totalFortnights = (Days/ fortnightDays) + 1;

            double hostingCost = ((totalFortnights * costPerFortnight * 100)) / 100;
            double taxAmount = ((hostingCost * taxRate * 100)) / 100;
            double totalAmount = (((hostingCost + taxAmount) * 100)) / 100;

            return new string[]
            {
        $"{totalFortnights} {(totalFortnights <= 1 ? "fortnight" : "fortnights")} at ${costPerFortnight:F2}/FN = ${hostingCost:F2} CAD",
        $"Tax {taxRate * 100}% = ${taxAmount} CAD",
        $"Total = ${totalAmount} CAD"
            };
        }

    }
}
