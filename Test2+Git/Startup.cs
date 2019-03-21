using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test2_Git.Startup))]
namespace Test2_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
