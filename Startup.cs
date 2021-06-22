using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Covid_19_Tracking.Startup))]
namespace Covid_19_Tracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
