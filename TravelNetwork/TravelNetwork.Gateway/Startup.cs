using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelNetwork.Gateway.Startup))]
namespace TravelNetwork.Gateway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
