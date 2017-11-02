using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    public class SingleHub : Hub
    {
        public void SendMessageToServer(string name, string message)
        {
            var userId = Context.ConnectionId;
            message = name + "獨自說：" + message;

            Clients.Client(Context.ConnectionId).sendMessgeToClient(message);
        }
    }
}