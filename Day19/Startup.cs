using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day19.Startup))]
namespace Day19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
