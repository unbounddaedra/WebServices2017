using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassAssignment3.Startup))]
namespace InClassAssignment3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
