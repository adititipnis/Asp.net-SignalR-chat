using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR1
{
    public class ChatHub : Hub
    {
        public void SendMessage(string msg)
        {
            Clients.All.ReceiveMessage(msg);
        }
    }
}