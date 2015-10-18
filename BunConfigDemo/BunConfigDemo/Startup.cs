using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BunConfigDemo.Startup))]
namespace BunConfigDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
