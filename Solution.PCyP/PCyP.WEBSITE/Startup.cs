using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCyP.WEBSITE.Startup))]
namespace PCyP.WEBSITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
