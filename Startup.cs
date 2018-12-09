using Owin;
using System.Web.Http;

namespace AspDotNetWebAPITemplate
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            appBuilder.UseWebApi(config);
        }

    }
}