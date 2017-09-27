using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebA.Startup))]
namespace WebA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
