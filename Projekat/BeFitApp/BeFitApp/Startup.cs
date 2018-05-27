using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeFitApp.Startup))]
namespace BeFitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
