using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using System.Web.Http.Tracing;
using Microsoft.Azure.Mobile.Server;

namespace EscuelasDeportivas.Service.Controllers
{
    // Use the MobileAppController attribute for each ApiController you want to use  
    // from your mobile clients 
    [MobileAppController]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            MobileAppSettingsDictionary settings = this.Configuration.GetMobileAppSettingsProvider().GetMobileAppSettings();
            ITraceWriter traceWriter = this.Configuration.Services.GetTraceWriter();

            string host = settings.HostName ?? "localhost";
            string greeting = "Hello from " + host;

            traceWriter.Info(greeting);
            return greeting;

            //return "Hello World!";
        }

        // POST api/values
        public string Post()
        {
            return "Hello World!";
        }
    }
}
