using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_14.Startup))]
namespace Lab_14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
