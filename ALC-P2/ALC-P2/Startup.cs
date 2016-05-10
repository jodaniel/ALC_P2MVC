using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALC_P2.Startup))]
namespace ALC_P2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
