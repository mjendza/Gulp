using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace API.Controllers
{
    public class JavaScriptGeneratorController : ApiController
    {
        [EnableTag]
        [HttpGet]
        public ResponseMessageResult Get()
        {
            var str = "var abc='a'";

            var response = ResponseMessage(new HttpResponseMessage()
            {
                Content = new StringContent(str, Encoding.UTF8, "application/javascript"),
                StatusCode = HttpStatusCode.OK,
            });

            return response;
        }
    }
}