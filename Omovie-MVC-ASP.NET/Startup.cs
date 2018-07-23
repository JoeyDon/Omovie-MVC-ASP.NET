using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Omovie_MVC_ASP.NET.Startup))]
namespace Omovie_MVC_ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
