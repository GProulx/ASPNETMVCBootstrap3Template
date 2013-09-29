using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETMVCBootstrap3Template.Startup))]
namespace ASPNETMVCBootstrap3Template
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
