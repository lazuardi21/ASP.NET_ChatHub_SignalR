using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalR_Server
{
    public class ChatHub : Hub
    {
        public void Disconnect()
        {
            Debug.WriteLine(Context.ConnectionId + " disconnected");
        }
        public async Task Send(string name, string message)
        {
            await Clients.All.broadcastMessage(name, message);
        }

        public async Task SendMessage(string message, int color, string username)
        {
            await Clients.All.UpdateChatMessage(message, color, username);
        }
        public async Task SendToUser(string user, string receiverConnectionId, string message)
        {
            await Clients.Client(receiverConnectionId).SendAsync(user, message);
        }
    }
}