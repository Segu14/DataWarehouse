using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMONUEVO_DataWarehouse.Startup))]
namespace COMONUEVO_DataWarehouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
