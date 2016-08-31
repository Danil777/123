using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetAzuraRabotka.Startup))]
namespace NetAzuraRabotka
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
