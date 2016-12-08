using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtesaniaMomotombo.Startup))]
namespace ArtesaniaMomotombo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
