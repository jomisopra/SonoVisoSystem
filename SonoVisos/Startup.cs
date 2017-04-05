using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonoVisos.Startup))]
namespace SonoVisos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
