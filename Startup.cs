using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectBv2.Startup))]
namespace ProjectBv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
