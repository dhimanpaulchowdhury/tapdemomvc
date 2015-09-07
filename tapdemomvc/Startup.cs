using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tapdemomvc.Startup))]
namespace tapdemomvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
