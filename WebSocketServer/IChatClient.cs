namespace TestWebSockets;

public interface IChatClient
{
    Task TextMessage(string message);
    Task ReceiveMessage(string message);
}