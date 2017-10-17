using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pcshop.Startup))]
namespace pcshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
