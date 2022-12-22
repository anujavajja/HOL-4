using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HOL_4.Startup))]
namespace HOL_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
