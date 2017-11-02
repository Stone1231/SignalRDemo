using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
    public class ChatHub : Hub
    {
        public void Hello(string name)
        {
            //這邊會傳入name參數
            //呼叫所有連線狀態中頁面上的 javascript function => hello
            //透過server端呼叫client的javascript function
            var userId = Context.ConnectionId;
            string message = "歡迎使用者 " + name + " 加入聊天室";
            Clients.All.hello(message);
        }

        public void SendMessage(string name, string message)
        {
            //這邊會傳入name和message參數
            //並且會呼叫所有連線狀態中頁面上的 javascript function => sendAllMessage
            //透過server端呼叫client的javascript function
            var userId = Context.ConnectionId;
            message = name + "說：" + message;

            Clients.All.sendAllMessge(message);
            //Clients.Client(Context.ConnectionId).sendAllMessge(message);
        }
    }
}