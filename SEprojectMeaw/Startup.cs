using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEprojectMeaw.Startup))]
namespace SEprojectMeaw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
