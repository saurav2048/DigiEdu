using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Edu.CampusOnCloud.WebApp.Startup))]
namespace Edu.CampusOnCloud.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
