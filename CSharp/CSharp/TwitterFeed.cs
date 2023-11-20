namespace CSharp;

public class TwitterFeed : IMessageManager
{
    public void PostMessage(string message)
    {
        Console.WriteLine($"{message} - from {nameof(TwitterFeed)}");
    }

    public string GetMessage(int messageId)
    {
        return FakeExternalClient.GetMessage(messageId);
    }
}