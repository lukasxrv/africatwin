using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AfricaTwin.cz.Startup))]
namespace AfricaTwin.cz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
