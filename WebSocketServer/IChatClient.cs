namespace TestWebSockets;

public interface IChatClient
{
    Task ReceiveMessage(string message);
}