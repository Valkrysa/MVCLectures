using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLectures.Startup))]
namespace MVCLectures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
