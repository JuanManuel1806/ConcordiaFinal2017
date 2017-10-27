using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Concordia.Startup))]
namespace Concordia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
