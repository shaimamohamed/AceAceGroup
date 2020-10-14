using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AceAceGroupTestApplication.Startup))]
namespace AceAceGroupTestApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
