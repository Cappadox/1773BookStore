using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1773BookStore.Startup))]
namespace _1773BookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
