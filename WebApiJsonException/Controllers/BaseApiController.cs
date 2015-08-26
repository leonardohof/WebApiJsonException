using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiJsonException.Models;

namespace WebApiJsonException.Controllers
{
    public class BaseApiController : ApiController
    {
        public HttpResponseException CreateHttpResponseException(HttpStatusCode code, ErrorModel errorModel)
        {
            var result = new HttpResponseException(code);
            result.Response.Content = new StringContent(JsonConvert.SerializeObject(errorModel));

            return result;
        }
    }
}
