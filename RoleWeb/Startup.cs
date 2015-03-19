using Owin;
using R = RolesLib;

namespace RoleWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            R.Startup.ConfigureAuth(app, Properties.Settings.Default.LoginPath);
        }
    }
}
