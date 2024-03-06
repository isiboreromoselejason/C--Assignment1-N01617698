using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Correction.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Calculates and returns the square of the given integer.
        /// </summary>
        /// <param name="id">The input integer for which the square is calculated.</param>
        /// <returns>
        /// Returns an integer representing the square of the input ID.
        /// </returns>
        /// <example>
        /// Get/api/Square/2 -> 4
        /// </example>

        public int Get(int id)
        {
            return id * id;
        }
    }
}
