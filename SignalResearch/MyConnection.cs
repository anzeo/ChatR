using System;
using System.Web;
using SignalR;
using System.Threading.Tasks;

namespace SignalResearch
{
    public class MyConnection : PersistentConnection
    {
        protected override Task OnConnectedAsync(HttpContextBase context, string clientId)
        {
            return Connection.Broadcast("Client" + clientId + " connected.");
        }
        protected override Task OnReceivedAsync(string clientId, string data)
        {
            // Broadcast data to all clients
            return Connection.Broadcast(data);
        }

        protected override Task OnDisconnectAsync(string clientId)
        {
            return Connection.Broadcast("Client"+ clientId + " logged off");
        }

        protected override void OnDisconnect(string clientId)
        {
            base.OnDisconnect(clientId);
        }
    }
}