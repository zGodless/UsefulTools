using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsefulTools.Startup))]
namespace UsefulTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
