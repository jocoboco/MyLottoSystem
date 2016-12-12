using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLottoSystem.Startup))]
namespace MyLottoSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
