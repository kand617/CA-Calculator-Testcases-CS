/*
 * APIMATICCalculatorTestcases.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/23/2017
 */
using System;
using APIMATICCalculatorTestcases.PCL;
using APIMATICCalculatorTestcases.PCL.Utilities;
using APIMATICCalculatorTestcases.PCL.Http.Client;
using APIMATICCalculatorTestcases.PCL.Http.Response;
using APIMATICCalculatorTestcases.PCL.Exceptions;

namespace APIMATICCalculatorTestcases.PCL.Controllers
{
    public partial class BaseController
    {
        #region shared http client instance
        private static object syncObject = new object();
        private static IHttpClient clientInstance = null;

        public static IHttpClient ClientInstance
        {
            get
            {
                lock(syncObject)
                {
                    if(null == clientInstance)
                    {
                        clientInstance = new UnirestClient()
;
                    }
                    return clientInstance;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is IHttpClient)
                    {
                        clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>
        /// <param name="_context">Context of the request and the recieved response</param>
        internal void ValidateResponse(HttpResponse _response, HttpContext _context)
        {
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);
        }
    }
} 