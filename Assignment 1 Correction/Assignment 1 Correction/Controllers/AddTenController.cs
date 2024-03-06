using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Correction.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Calculates and returns the result by adding 10 to the given integer.
        /// </summary>
        /// <param name="id">The input integer to which 10 is added.</param>
        /// <returns>
        /// Returns an integer representing the result of adding 10 to the input ID.
        /// </returns>
        /// <example>
        ///     Get/api/addten/21 -> 31
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
