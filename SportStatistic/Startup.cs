using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportStatistic.Startup))]
namespace SportStatistic
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
