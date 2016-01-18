using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnightOwlMVC.Startup))]
namespace KnightOwlMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
