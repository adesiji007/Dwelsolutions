using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dwelsolutions.Startup))]
namespace Dwelsolutions
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
