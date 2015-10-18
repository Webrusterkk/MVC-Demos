using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COOKIEDEMO2.Startup))]
namespace COOKIEDEMO2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
