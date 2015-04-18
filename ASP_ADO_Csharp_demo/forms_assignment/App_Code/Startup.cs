using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lee_cis258_form.Startup))]
namespace lee_cis258_form
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
