using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace AspDotNetWebAPITemplate.Controllers
{
    public class ValuesController:ApiController
    {
        [Route("api/values")]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1","value2"};
        }
    }
}
