using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git_example.Startup))]
namespace git_example
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
