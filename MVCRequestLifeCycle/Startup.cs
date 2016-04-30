using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRequestLifeCycle.Startup))]
namespace MVCRequestLifeCycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
