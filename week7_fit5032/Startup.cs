using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week7_fit5032.Startup))]
namespace week7_fit5032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
