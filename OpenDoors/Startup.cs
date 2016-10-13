using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenDoors.Startup))]
namespace OpenDoors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
