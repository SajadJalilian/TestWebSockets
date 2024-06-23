using Microsoft.AspNetCore.SignalR;

namespace TestWebSockets;

public class ChatHub : Hub<IChatClient>
{
    public override async Task OnConnectedAsync()
    {
        await Clients.All.ReceiveMessage($"{Context.ConnectionId} : is joined");
    }
    
    public async Task TextMessage(string message)
    {
        var newString = $"--{message}--";
        await Clients.Caller.TextMessage(newString);
    }

    public async Task CallTheServer()
    {
        Console.WriteLine("CallTheServer is called from client");
    }

}