using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalR_Server.Startup))]

namespace SignalR_Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any Connection or hub wire and configuration go here
            app.MapSignalR();
        }
    }
}
