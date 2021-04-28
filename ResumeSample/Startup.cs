using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeSample.Startup))]
namespace ResumeSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
