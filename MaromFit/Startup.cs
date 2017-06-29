using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaromFit.Startup))]
namespace MaromFit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
