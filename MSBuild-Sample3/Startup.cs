using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSBuild_Sample3.Startup))]
namespace MSBuild_Sample3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
