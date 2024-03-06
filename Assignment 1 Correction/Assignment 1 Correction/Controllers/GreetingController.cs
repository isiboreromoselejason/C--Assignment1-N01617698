using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Correction.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Gets a default greeting string "Hello World!".
        /// </summary>
        /// <returns>
        /// Returns a string containing the default greeting "Hello World!".
        /// </returns>
        /// <example>
        ///  Get/api/greeting -> Hello World
        /// </example>

        /// <summary>
        /// Gets a personalized greeting string by concatenating "Hello to " with the provided ID and " People!".
        /// </summary>
        /// <param name="id">The string ID used to personalize the greeting.</param>
        /// <returns>
        /// Returns a string representing a personalized greeting based on the provided ID.
        /// </returns>
        /// <example>
        /// Get/api/greeting/3 -> Hello to 3 People!
        /// </example>

        public string Get()
        {
            return "Hello World!";
        }
        public string Get(string id)
        {
            return "Hello to " + id + " People!";
        }
    }
}
