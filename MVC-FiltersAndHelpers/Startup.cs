using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_FiltersAndHelpers.Startup))]
namespace MVC_FiltersAndHelpers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
