using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaoCaoLTW.Startup))]
namespace BaoCaoLTW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
