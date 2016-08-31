using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetAsyreRabotka.Startup))]
namespace NetAsyreRabotka
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
