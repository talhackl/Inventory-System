using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventory_System.Startup))]
namespace Inventory_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
