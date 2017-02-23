/*
 * APIMATICCalculatorTestcases.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/23/2017
 */
using APIMATICCalculatorTestcases.PCL.Http.Client;
using APIMATICCalculatorTestcases.PCL.Http.Request;
using APIMATICCalculatorTestcases.PCL.Http.Response;

namespace APIMATICCalculatorTestcases.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}
