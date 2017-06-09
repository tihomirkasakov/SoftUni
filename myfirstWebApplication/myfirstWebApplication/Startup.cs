using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myfirstWebApplication.Startup))]
namespace myfirstWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
