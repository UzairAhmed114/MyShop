using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopWebUI.Startup))]
namespace MyShopWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
