using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDeveloperFinal.Startup))]
namespace WebDeveloperFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
