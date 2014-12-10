using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenYannickJens.Startup))]
namespace ExamenYannickJens
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
