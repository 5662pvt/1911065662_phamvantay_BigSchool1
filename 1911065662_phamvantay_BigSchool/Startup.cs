using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065662_phamvantay_BigSchool.Startup))]
namespace _1911065662_phamvantay_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
