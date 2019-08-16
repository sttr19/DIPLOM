using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DP_60321_TROSHKO.Startup))]
namespace DP_60321_TROSHKO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
