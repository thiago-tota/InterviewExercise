namespace CSharp;

public class FacebookFeed : IMessageManager
{
    public void PostMessage(string message)
    {
        Console.WriteLine($"{message} - from {nameof(FacebookFeed)}");
    }

    public string GetMessage(int messageId)
    {
        return FakeExternalClient.GetMessage(messageId);
    }
}