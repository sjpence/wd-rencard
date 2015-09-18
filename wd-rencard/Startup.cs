using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wd_rencard.Startup))]
namespace wd_rencard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
