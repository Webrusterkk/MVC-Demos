using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidDemo.Startup))]
namespace ValidDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
