using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCorola.Startup))]
namespace TestCorola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
