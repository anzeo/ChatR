using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;
using System.Threading;
using System.Collections;

namespace SignalResearch
{
    public class MyHub : Hub, IDisconnect
    {
        public void LogOn(String nickName)
        {
            UserDB.add(Context.ClientId, nickName);
            Clients.updateUserList(UserDB.getAll(), nickName + " connected.");
        }

        public void Send(String message) {
            Clients.addMessage(UserDB.get(Context.ClientId) + ": " + message);
        }

        public void Disconnect()
        {
            String userName = UserDB.get(Context.ClientId);
            UserDB.remove(Context.ClientId);
            Clients.updateUserList(UserDB.getAll(),userName + " disconnected.");
            
        }
    }
}