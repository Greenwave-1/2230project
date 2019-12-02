using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finalproject2.Startup))]
namespace finalproject2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
} //hi
