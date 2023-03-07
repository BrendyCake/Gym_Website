using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gym_Web.Startup))]
namespace Gym_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
