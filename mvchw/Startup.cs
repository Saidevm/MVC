using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvchw.Startup))]
namespace mvchw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
