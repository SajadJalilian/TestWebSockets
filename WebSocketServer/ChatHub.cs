using Microsoft.AspNetCore.SignalR;

namespace TestWebSockets;

public class ChatHub : Hub<IChatClient>
{
    public async Task TextMessage(string message)
    {
        var newString = $"--{message}--";
        await Clients.Caller.TextMessage(newString);
    }
}