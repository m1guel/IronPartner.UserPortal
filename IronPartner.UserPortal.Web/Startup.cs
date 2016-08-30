using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IronPartner.UserPortal.Web.Startup))]
namespace IronPartner.UserPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
