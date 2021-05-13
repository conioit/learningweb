using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(learning.Startup))]
namespace learning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
