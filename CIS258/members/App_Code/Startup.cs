using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(members.Startup))]
namespace members
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
