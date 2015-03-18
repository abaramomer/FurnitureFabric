using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FurnitureFabric.Startup))]
namespace FurnitureFabric
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
