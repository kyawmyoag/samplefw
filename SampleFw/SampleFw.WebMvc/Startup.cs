using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleFw.WebMvc.Startup))]
namespace SampleFw.WebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
