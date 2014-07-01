using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesProject1.Startup))]
namespace MoviesProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
