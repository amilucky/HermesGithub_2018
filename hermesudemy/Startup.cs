using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hermesudemy.Startup))]
namespace hermesudemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
