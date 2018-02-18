using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SigChat.Startup))]
namespace SigChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            // Any connection or hub wire up and configrathion should go here
            app.MapSignalR();
        }
    }
}
