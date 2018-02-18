using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SigChat.Hubs
{
    public class ChatHub : Hub
    {
       public void Send(String name, string message)
        {
            // Call the addNewMessageToPage method to update clinet
            Clients.All.addNewMessageToPage(name, message);

        }
    }
}