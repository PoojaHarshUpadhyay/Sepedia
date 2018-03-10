using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SepediaMVC.Startup))]
namespace SepediaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
