using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZhiJun.Startup))]
namespace ZhiJun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
