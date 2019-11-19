using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shareddatacenter.Startup))]
namespace shareddatacenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
