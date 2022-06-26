using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs{
    public class ChatHub : Hub{
        public async Task SendMessage(string usr , string message)
        {
            await Clients.All.SendAsync("ReceiveMessage" , usr, message);
        } // SendMessage

          public async Task SendTestMessage(string usr , string message)
        {
            await Clients.All.SendAsync("TestMessage" , usr, message);
        } // SendMessage


    }//class : ChartHub    
}// namespace : SignalRChat

