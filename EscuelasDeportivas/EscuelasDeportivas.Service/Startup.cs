using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EscuelasDeportivas.Service.Startup))]

namespace EscuelasDeportivas.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}