using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Correction.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Gets a calculated result based on the input ID, applying different rules for different ID ranges.
        /// </summary>
        /// <param name="id">The input ID used to determine the result.</param>
        /// <returns>
        /// Returns an integer representing the calculated result based on specific conditions:
        /// - If ID is less than 1, returns ID plus 10.
        /// - If ID is between 1 and 10 (inclusive), returns ID minus 1.
        /// - If ID is between 11 and 20 (inclusive), returns the square of ID.
        /// - For any other ID values, returns ID divided by 2.
        /// </returns>
        /// <example>
        /// 
        ///     Get/api/numbermachine/11 -> 121
        ///    
        /// </example>

        public int Get(int id)
        {
            if (id < 1)
            {
                return id + 10;
            }
            else if (id >= 1 && id <= 10)
            {
                return id - 1;
            }
            else if (id > 10 && id <= 20)
            {
                return id * id;
            }
            else
            {
                return id / 2;
            }
        }
    }

}
